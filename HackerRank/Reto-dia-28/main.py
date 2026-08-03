import re

def main():
    n = int(input().strip())
    gmail_names = []
    pattern = re.compile(r'@gmail\.com$')

    for _ in range(n):
        first_name, email_id = input().strip().split()
        if pattern.search(email_id):
            gmail_names.append(first_name)

    gmail_names.sort()

    for name in gmail_names:
        print(name)

if __name__ == '__main__':
    main()