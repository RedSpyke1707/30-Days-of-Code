class Person:
    def __init__(self, Edad_inicial):
        if Edad_inicial < 0:
            print("Aun no has nacido.")
            self.age = 0
        else:
            self.age = Edad_inicial

    def amIOld(self):
        if self.age < 13:
            print("Eres un niño/a.")
        elif 13 <= self.age < 18:
            print("Eres un/a adolescente.")
        else:
            print("Eres mayor de edad.")

    def yearPasses(self):
        self.age += 1
t = int(input())
for i in range(0, t):
    age = int(input())         
    p = Person(age)  
    p.amIOld()
    for j in range(0, 3):
        p.yearPasses()       
    p.amIOld()
    print("")