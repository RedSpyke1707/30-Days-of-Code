import math
import sys


def is_prime(n):
  if n <= 1:
    return False
  if n <= 3:
    return True
  if n % 2 == 0 or n % 3 == 0:
    return False

  i = 5
  while i * i <= n:
    if n % i == 0 or n % (i + 2) == 0:
      return False
    i += 6
  return True


def solve():
  input_data = sys.stdin.read().split()
  if not input_data:
    return
  t = int(input_data[0])
  for i in range(1, t + 1):
    n = int(input_data[i])
    if is_prime(n):
      print("Prime")
    else:
      print("Not prime")


if __name__ == "__main__":
  solve()