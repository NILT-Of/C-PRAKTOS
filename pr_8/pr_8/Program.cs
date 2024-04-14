HashSet<string> dni = new HashSet<string>
{
    "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"
}; // Создаём множество с днями недели
foreach(string den in dni)
{
    Console.WriteLine(den);
} // Выводим элементы множества