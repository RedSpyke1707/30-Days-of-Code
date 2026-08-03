import sys

def main():
    lines = sys.stdin.read().split()
    if not lines:
        return

    d1, m1, y1 = map(int, lines[0:3])
    d2, m2, y2 = map(int, lines[3:6])

    fine = 0

    if y1 > y2:
        fine = 10000
    elif y1 == y2:
        if m1 > m2:
            fine = 500 * (m1 - m2)
        elif m1 == m2 and d1 > d2:
            fine = 15 * (d1 - d2)

    print(fine)

if __name__ == '__main__':
    main()