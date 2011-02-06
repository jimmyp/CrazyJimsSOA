using System;

namespace CrazyJims.Common
{
    public static class Guard
    {
        public static void AgainstNullArguments(object name, string argumentName)
        {
            if (name == null)
                throw new ArgumentNullException(argumentName);
        }
    }
}