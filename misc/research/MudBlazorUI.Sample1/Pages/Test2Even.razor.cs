// Conjure application framework.
// Copyright (C) Conjure.

using Conjure.BlazorKit.Events;

namespace MudBlazorUI.Sample1.Pages;

public partial class Test2Even
{
    internal static bool ComputeCanExecute() => DateTime.Now.Minute % 2 == 0;
}
