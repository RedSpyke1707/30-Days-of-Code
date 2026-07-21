import sys

def main():
    data = sys.stdin.read().split('\n')
    n = int(data[0])
    phone_book = {}
    for i in range(1, n + 1):
        name, number = data[i].split()
        phone_book[name] = number
    
    for line in data[n + 1:]:
        name = line.strip()
        if name == '':
            continue
        if name in phone_book:
            print(f"{name}={phone_book[name]}")
        else:
            print("Not found")

if __name__ == '__main__':
    main()