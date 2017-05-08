using System;

namespace EcommerceData
{
    public class IdGenerator
    {
        public static string NewId() => Guid.NewGuid().ToString().Replace("-", string.Empty);

    }
}