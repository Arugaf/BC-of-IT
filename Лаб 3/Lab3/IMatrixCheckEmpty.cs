namespace Lab3
{
    //методы данного интерфейса используются при создании разреженной матрицы
    public interface IMatrixCheckEmpty<T>
    {
        //возвращает пустой элемент
        T getEmptyElement();
        //проверка, что элемент является пустым
        bool CheckEmptyElement(T element);
    }
}