#include <iostream>
#include <vector>

int bitwiseAnd(int N, int K) {
    if (((K - 1) | K) <= N) {
        return K - 1;
    } else {
        return K - 2;
    }
}

int main() {
    // Optimización de I/O para C++
    std::ios_base::sync_with_stdio(false);
    std::cin.tie(NULL);

    int t;
    if (std::cin >> t) {
        while (t--) {
            int n, k;
            std::cin >> n >> k;
            std::cout << bitwiseAnd(n, k) << "\n";
        }
    }

    return 0;
}