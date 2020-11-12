using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exercise3_4
{
    class SortById : Comparer<Account>
    {
        public override int Compare([AllowNull] Account x, [AllowNull] Account y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
    class SortByName : Comparer<Account>
    {
        public override int Compare([AllowNull] Account x, [AllowNull] Account y)
        {
            return x.Fname.CompareTo(y.Fname);
        }
    }
    class SortByBalance : Comparer<Account>
    {
        public override int Compare([AllowNull] Account x, [AllowNull] Account y)
        {
            return x.Balance.CompareTo(y.Balance);
        }
    }
}
