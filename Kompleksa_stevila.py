from math import *
class KompleksnaStevila(object):
    '''Razred, ki vsebuje metode za osnovne operacije nad kompleksnimi števili.'''
    def __init__(self, realna, imaginarna=0.0):
        self.realna = realna
        self.imaginarna = imaginarna

    def __add__(self, other):
        return KompleksnaStevila(self.realna + other.realna, self.imaginarna + other.imaginarna)

    def __sub__(self, other):
        return KompleksnaStevila(self.realna - other.realna, self.imaginarna - other.imaginarna)

    def __mul__(self, other):
        return KompleksnaStevila(self.realna*other.realna - self.imaginarna*other.imaginarna,
                       self.imaginarna*other.realna + self.realna*other.imaginarna)

    def __truediv__(self, other):
        Re1, Im1, Re2, Im2 = self.realna, self.imaginarna, other.realna, other.imaginarna # short forms
        r = float(Re2**2 + Im2**2)
        return KompleksnaStevila((Re1*Re2+Im1*Im2)/r, (Im1*Re2-Re1*Im2)/r)

    def __abs__(self):
        return sqrt(self.realna**2 + self.imaginarna**2)

    def __neg__(self):   
        return KompleksnaStevila(-self.realna, -self.imaginarna)

    def __eq__(self, other):
        return self.realna == other.realna and self.imaginarna == other.imaginarna

    def __ne__(self, other):
        return not self.__eq__(other)

    def __str__(self):
        return '({}, {})'.format(self.realna, self.imaginarna)
    def __repr__(self):
        return 'KompleksnaStevila' + str(self)


#TESTNI PRIMERI
u = KompleksnaStevila(3, -1)
v = KompleksnaStevila(-1, 2)
print("Kompleksno število u je " + str(u))
print("Kompleksno število v je " + str(v))
print ("Vsota kompleksnih števil u in v je " + str(u+v))
print("Razlika komplesnih števil u in v je " + str(u-v))
print ("Produkt kompleksnih števil u in v je " + str(u*v))
print ("Količnik kompleksnih števil u in v je " + str(u/v))
print ("Absolutna vrednost u je " + str(abs(u)))