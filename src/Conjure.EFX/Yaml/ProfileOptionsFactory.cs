using System.Threading;
using Conjure.EFX.Options;
using YamlDotNet.Serialization;

namespace Conjure.EFX.Yaml
{
        // This code is _*heavily*_ based on EFG:
        //    https://github.com/loresoft/EntityFrameworkCore.Generator/

    public class ProfileOptionsFactory : IObjectFactory
    {
        private readonly ProfileOptions _profileOptions;
        private int _scriptCount;

        public ProfileOptionsFactory(ProfileInfo profile)
        {
            _profileOptions = new ProfileOptions(profile);
            _profileOptions.Variables.ShouldEvaluate = false;
            _scriptCount = 0;
        }

        public object Create(Type type)
        {
            // work around YamlDotNet requiring parameterless constructor
            if (type == typeof(ProfileOptions))
                return _profileOptions;

            if (type == typeof(ProjectOptions))
                return _profileOptions.Project;
            if (type == typeof(DatabaseOptions))
                return _profileOptions.Database;
            if (type == typeof(DataOptions))
                return _profileOptions.Data;
            if (type == typeof(ModelOptions))
                return _profileOptions.Model;
            if (type == typeof(ScriptOptions))
                return _profileOptions.Script;

            if (type == typeof(ContextClassOptions))
                return _profileOptions.Data.Context;
            if (type == typeof(EntityClassOptions))
                return _profileOptions.Data.Entity;
            if (type == typeof(MappingClassOptions))
                return _profileOptions.Data.Mapping;
            if (type == typeof(QueryExtensionOptions))
                return _profileOptions.Data.Query;

            if (type == typeof(SharedModelOptions))
                return _profileOptions.Model.Shared;
            if (type == typeof(ReadModelOptions))
                return _profileOptions.Model.Read;
            if (type == typeof(CreateModelOptions))
                return _profileOptions.Model.Create;
            if (type == typeof(UpdateModelOptions))
                return _profileOptions.Model.Update;
            if (type == typeof(MapperClassOptions))
                return _profileOptions.Model.Mapper;
            if (type == typeof(ValidatorClassOptions))
                return _profileOptions.Model.Validator;

            if (type == typeof(TemplateOptions))
            {
                var index = Interlocked.Increment(ref _scriptCount);
                var prefix = $"Script{index}";

                return new TemplateOptions(_profileOptions.Variables, prefix);
            }

            return Activator.CreateInstance(type);
        }
    }
}