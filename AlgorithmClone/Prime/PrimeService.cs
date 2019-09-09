using System;

namespace AlgorithmClone.Prime {
    public interface IPrimeService {
        Boolean IsPrime(Int64 candidate);
    }

    public class PrimeService: IPrimeService {
        public Boolean IsPrime(Int64 candidate) {
            if(candidate < 2) {
                return false;
            }

            for(Int64 i = 2; i <= Math.Sqrt(candidate); ++i) {
                if(candidate % i == 0) {
                    return false;
                }
            }

            return true;
        }
    }
}