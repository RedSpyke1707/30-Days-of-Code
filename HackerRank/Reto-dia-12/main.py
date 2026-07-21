def __init__(self, firstName, lastName, id, scores):
    Person.__init__(self, firstName, lastName, id)
    self.scores = scores

def calculate(self):
    average = sum(self.scores) / len(self.scores)
    if average >= 90:
        return 'O'
    elif average >= 80:
        return 'E'
    elif average >= 70:
        return 'A'
    elif average >= 55:
        return 'P'
    elif average >= 40:
        return 'D'
    else:
        return 'T'