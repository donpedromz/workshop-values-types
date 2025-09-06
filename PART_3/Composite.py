# Array
names = ["Pablo","Luisa","Castri","Sebastian","Daniel"]
for name in names:
    print(name, end=",")
print()
# Class
class Car:
    def __init__(self, engine, tyres):
        self.engine = engine
        self.tyres = tyres
        print("Car Created!!")
rb21 = Car("Honda", "Pirelli P Zero C4")
print("Engine: ",rb21.engine)
print("Tyres: ",rb21.tyres)
# Dictionaries
grades = {
    "Pablo": 3.5,
    "Luisa": 5,
    "Castri": 4.8,
    "Sebas":4.8,
    "Daniel":4.81
}