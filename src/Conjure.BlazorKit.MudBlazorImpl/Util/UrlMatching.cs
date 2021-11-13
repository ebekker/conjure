// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Util;

internal static class UrlMatching
{
    public static bool ShouldMatch(string currentUriAbsolute, string targetHrefAbsolute,
        bool prefixMatch = false)
    {
        if (targetHrefAbsolute == null)
        {
            return false;
        }

        if (EqualsHrefExactlyOrIfTrailingSlashAdded(currentUriAbsolute, targetHrefAbsolute))
        {
            return true;
        }

        if (prefixMatch && IsStrictlyPrefixWithSeparator(currentUriAbsolute, targetHrefAbsolute))
        {
            return true;
        }

        return false;
    }

    private static bool EqualsHrefExactlyOrIfTrailingSlashAdded(string currentUriAbsolute, string targetHrefAbsolute)
    {
        if (string.Equals(currentUriAbsolute, targetHrefAbsolute, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (currentUriAbsolute.Length == targetHrefAbsolute.Length - 1)
        {
            // Special case: highlight links to http://host/path/ even if you're
            // at http://host/path (with no trailing slash)
            //
            // This is because the router accepts an absolute URI value of "same
            // as base URI but without trailing slash" as equivalent to "base URI",
            // which in turn is because it's common for servers to return the same page
            // for http://host/vdir as they do for host://host/vdir/ as it's no
            // good to display a blank page in that case.
            if (targetHrefAbsolute[targetHrefAbsolute.Length - 1] == '/'
                && targetHrefAbsolute.StartsWith(currentUriAbsolute, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsStrictlyPrefixWithSeparator(string value, string prefix)
    {
        var prefixLength = prefix.Length;
        if (value.Length > prefixLength)
        {
            return value.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)
                && (
                    // Only match when there's a separator character either at the end of the
                    // prefix or right after it.
                    // Example: "/abc" is treated as a prefix of "/abc/def" but not "/abcdef"
                    // Example: "/abc/" is treated as a prefix of "/abc/def" but not "/abcdef"
                    prefixLength == 0
                    || !char.IsLetterOrDigit(prefix[prefixLength - 1])
                    || !char.IsLetterOrDigit(value[prefixLength])
                );
        }
        else
        {
            return false;
        }
    }
}
