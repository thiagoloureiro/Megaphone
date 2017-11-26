using System;
using System.Threading;

namespace Megaphone.Core.Util
{
    public static class ThreadLocalRandom
    {
        private static int _seed = Environment.TickCount;

        private static readonly ThreadLocal<Random> Rng = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref _seed)));

        public static Random Current => Rng.Value;
    }
}