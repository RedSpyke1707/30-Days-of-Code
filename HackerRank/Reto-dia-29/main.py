import sys

def bitwiseAnd(N, K):
    if ((K - 1) | K) <= N:
        return K - 1
    else:
        return K - 2

def main():
    input_data = sys.stdin.read().split()
    if not input_data:
        return
    
    t = int(input_data[0])
    idx = 1
    
    results = []
    for _ in range(t):
        n = int(input_data[idx])
        k = int(input_data[idx + 1])
        idx += 2
        results.append(str(bitwiseAnd(n, k)))
    
    print('\n'.join(results))

if __name__ == '__main__':
    main()