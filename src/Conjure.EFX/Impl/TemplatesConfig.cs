// Conjure application framework.
// Copyright (C) Conjure.

using System.Collections;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Conjure.EFX.Options;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Conjure.EFX.Impl;

public class TemplatesConfig : ITemplatesConfig
{
    public static readonly IEnumerable<TemplateInfo> EmptyTemplateInfos = Enumerable.Empty<TemplateInfo>();
    public static readonly Regex AsmResUrl = new Regex("^asm://([^/]+)/(.+)$");

    public string TemplateFormat { get; set; }

    public List<TemplateConfigInfo> PerProject { get; set; }

    public List<TemplateConfigInfo> PerProfile { get; set; }

    public List<TemplateConfigInfo> PerEntity { get; set; }

    public List<TemplateConfigInfo> PerEntityModel { get; set; }

    public IEnumerable<TemplateInfo> ProjectTemplates { get; private set; }
    public IEnumerable<TemplateInfo> ProfileTemplates { get; private set; }
    public IEnumerable<TemplateInfo> EntityTemplates { get; private set; }
    public IEnumerable<TemplateInfo> EntityModelTemplates { get; private set; }

    private void ResolveTemplates(ProfileOptions options, string relativeRoot = null)
    {
        ProjectTemplates = GetTemplates(options, PerProject, relativeRoot);
        ProfileTemplates = GetTemplates(options, PerProfile, relativeRoot);
        EntityTemplates = GetTemplates(options, PerEntity, relativeRoot);
        EntityModelTemplates = GetTemplates(options, PerEntityModel, relativeRoot);
    }

    public static IEnumerable<TemplateInfo> GetTemplates(ProfileOptions options,
        List<TemplateConfigInfo> tcis, string relativeRoot = null)
    {
        return tcis == null
            ? EmptyTemplateInfos
            : tcis.Select(tci => new TemplateInfo
            {
                Name = tci.Name,
                Path = tci.Path,
                Body = GetResource(options.Variables.Evaluate(tci.Source ?? tci.Name), relativeRoot),
            });
    }

    public class TemplateConfigInfo
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string Source { get; set; }
    }

    public static string GetResource(string source, string relativeRoot = null)
    {
        if (string.IsNullOrEmpty(source))
        {
            throw new ArgumentNullException("source");
        }

        // Try to read it as an ASM-embedded resource
        var asmMatch = AsmResUrl.Match(source);
        if (asmMatch.Success)
        {
            var asmName = asmMatch.Groups[1].Value;
            var resPath = asmMatch.Groups[2].Value;

            var asm = Assembly.Load(asmName);
            if (asm == null)
            {
                throw new Exception("unable to resolve resource assembly: " + asmName);
            }

            using var res = asm.GetManifestResourceStream(resPath);
            if (res == null)
            {
                throw new Exception("unable to resolve assembly-embedded resource path: " + resPath);
            }

            using var str = new StreamReader(res);
            return str.ReadToEnd();
        }

        // Try to read it as a system-supported URL format
        else if (Uri.TryCreate(source, UriKind.Absolute, out var url))
        {
            using var res = new WebClient();
            return res.DownloadString(url);
        }

        // Default to treat it as a file path
        else
        {
            var filePath = source;
            if (!string.IsNullOrEmpty(relativeRoot))
            {
                filePath = Path.Combine(relativeRoot, filePath);
            }

            using var fs = File.OpenRead(filePath);
            using var str = new StreamReader(fs);
            return str.ReadToEnd();
        }
    }

    public static TemplatesConfig Load(ProfileOptions options, string source,
        string relativeRoot = null)
    {
        var yaml = GetResource(source, relativeRoot);
        var yamlDeser = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        var tc = yamlDeser.Deserialize<TemplatesConfig>(yaml);

        tc.ResolveTemplates(options, relativeRoot);

        return tc;
    }
}
