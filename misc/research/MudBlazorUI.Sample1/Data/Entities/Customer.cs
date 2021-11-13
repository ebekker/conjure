// Conjure application framework.
// Copyright (C) Conjure.

namespace ConjureApp.Data.Entities;

public partial class Customer
{
    public override string ToString()
    {
        return $"[{CustomerID}] {LastName}, {FirstName} {MiddleName} ({EmailAddress})";
    }
}
