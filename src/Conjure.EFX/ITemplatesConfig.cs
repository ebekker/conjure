// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.EFX;

public interface ITemplatesConfig
{
    IEnumerable<TemplateInfo> ProjectTemplates { get; }

    IEnumerable<TemplateInfo> ProfileTemplates { get; }

    IEnumerable<TemplateInfo> EntityTemplates { get; }

    IEnumerable<TemplateInfo> EntityModelTemplates { get; }
}
