import math

class Retangulo:
	def __init__(self, b, h):
		self.__b = b
		self.__h = h
	def set_base(self, b):
		self.__b = b
	def set_altura(self, h):
		self.__h = h
	def get_base(self):
		return self.__b
	def get_altura(self):
		return self.__h
	def calc_area(self):
		return (self.__b * self.__h)
	def diagonal(self):
		return (math.sqrt((self.__b**2) + (self.__h**2)))
	def __str__(self):
		return f"Base = {self.__b}, Altura = {self.__h}"


ret = Retangulo(2, 4)
print(ret.calc_area())
print(ret.diagonal())
print(ret)

ret.set_base(3)
print(ret.calc_area())
print(ret.diagonal())
print(ret)