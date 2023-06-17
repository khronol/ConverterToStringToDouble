# ConverterToStringToDouble
#EN
The task was to convert string to double without using special methods (Convert.ToDouble(),TryParse(),Parse()). 

At input the program receives a string in the form of double (for example 145.15), which in the final key should be composed of the type double to interact with it. In the first step, I initialized a variable of type double in order to store the result, as well as an array of int's with ASCII number codes to handle char characters. Thanks to the loops, the first thing to do is to check each character by comparing char and int and add the right value, first the left part (for example 145.15 = 145 ), then the loop to work out the left part (for example 145.15 = 15 ). I know how many digits after the decimal point from the values I get. I created a loop and a divider variable, which will be multiplied by 10 for every number from the second loop (for example 15 = divider = 100). Eventually I get a number, divide it by the required value and add the integer part already typed as double (145 + 15/100 =>(double) 145.15)


Конвертация string в формат double
#RU
Была поставлена задача конвертировать string в double без использования специальных методов (Convert.ToDouble(),TryParse(),Parse()). 

На вход программа получает строку в виде double(например 145.15), которая в итоговом ключе должна быть составлена типом double для взаимодействия с ней. В
первом шаге я инициализировал переменную типа double чтобы в дальнейшем сохранить в ней полученный результат, также массив int с ASCII кодами цифр для 
обработки char символов. Благодаря циклам в первую очередь идет проверка каждого символа в сравнении char и int по коду и добавление верного значения, сначала 
левая часть (например 145.15 = 145 ), затем цикл для отработки левой части (например 145.15 = 15 ). По полученным значениям я узнаю сколько знаков после 
запятой. Создал цикл и переменную делитель(divider), которая с помощью нового цикла будет умножаться на 10 за каждое число полученной во втором цикле ( 
например 15 = divider = 100 ). В конечном итоге я получаю число, делю его на необходимое значение и добавляю целую часть уже типизировано типом double (145 + 
15/100 =>(double) 145.15)
