#Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
def InputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = float(input(f"{inputText}"))
            is_OK = True
        except ValueError:
            print("Это не число!")
    return number


def sumNums(num):
    sum = 0
    for i in str(num):
        if i != ".":
            sum += int(i)
    return sum


num = InputNumbers("Введите число: ")

print(f"Сумма цифр = {sumNums(num)}")






#Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
def InputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f"{inputText}"))
            is_OK = True
        except ValueError:
            print("Число должно быть integer ")
    return number


def mult(n):
    if n == 1:
        return 1
    else:
        return n * mult(n - 1)


num = InputNumbers("Введите число: ")

list = []
for e in range(1, num + 1):
    list.append(mult(e))

print(f"Произведения чисел от 1 до {num}:  {list}")







#Задайте список из n чисел последовательности (1 + 1/n) ** n и выведите на экран их сумму.
print('Введите число')
n = int(input())
print('[', end = '')

for i in range (1, n + 1):
    res = round((1 + 1 / n)**n, 3)
    sum = int(sum([res for res in range(i + 1)]))
    if i < (n + 1) -1: 
        print(f'{sum}', end = ', ')
    else: print(f'{sum}', end = '')
print(']', end = '')






#Реализуйте алгоритм перемешивания списка.
import random
def ran():
    y = ['Я ', 'Учил ', 'Уроки ', 'Весь ', 'День']
    random.shuffle(y)
 
    print(y)




