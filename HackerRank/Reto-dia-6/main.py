t = int(input("HackerRank"))


for _ in range(t):
    s = input("HackerRank")
    
    pares = s[0::2]   
    impares = s[1::2] 
    
    print(f"{pares} {impares}")