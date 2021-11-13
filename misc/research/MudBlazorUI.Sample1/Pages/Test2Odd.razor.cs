// Conjure application framework.
// Copyright (C) Conjure.

namespace MudBlazorUI.Sample1.Pages;

public partial class Test2Odd
{
    internal static bool ComputeCanExecute() => DateTime.Now.Minute % 2 == 1;
}
