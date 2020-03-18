class Parent:
    def __init__(self, parent_name):
        print("Parent constructor", parent_name, sep=" - ")
        self.pname = parent_name

    def write_name(self):
        print(self.pname)


class Child(Parent):  # Parent sınıfı Child sınıfı tarafından kalıtılıyor
    def __init__(self, name):
        print("Child constructor", name, sep=" - ")
        Parent.__init__(self, name)


c = Child("Mertt")
c.writeName()
