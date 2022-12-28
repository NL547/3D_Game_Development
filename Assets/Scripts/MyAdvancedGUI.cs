using UnityEngine;


public class MyAdvancedGUI : MonoBehaviour
{
    [SerializeField, Range(0f, 5f)]
    [Tooltip("Значение находится в диапазоне от 0 до 5")]
    private float mySlider = 1.0f; // Положение пользовательского слайдера
    [Header("Custom color")]
    public Color myColor;         // Градиент цвета
    public MeshRenderer GO;      // Ссылка на рендер объекта

    [SerializeField, TextArea(5, 10)]
    private string field;

    [SerializeField] public Sprite sprite;

    void OnGUI()
    {
        mySlider = LabelSlider(new Rect(900, 10, 200, 20), mySlider, 0.0f, 5.0f, "My Slider"); // Отрисовка пользовательского слайдера        

        myColor = RGBASlider(new Rect(900, 30, 200, 20), myColor);  // Отрисовка пользовательского набора слайдеров для получения градиента цвета
        GO.material.color = myColor; // Покраска объекта
    }

    // Отрисовка пользовательского слайдера
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMinValue, float sliderMaxValue, string labelText) // ДЗ добавить MinValue
    {
        // создаём прямоугольник с координатами в пространстве и заданой шириной и высотой 
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);

        GUI.Label(labelRect, labelText);   // создаём Label на экране

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height); // Задаём размеры слайдера
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue); // Вырисовываем слайдер и считываем его параметр
        return sliderValue; // Возвращаем значение слайдера
    }

    // Отрисовка тройной слайдер группы, каждый слайдер отвечает за свой цвет
    Color RGBASlider(Rect screenRect, Color rgbA)
    {
        // Используя пользовательский слайдер, создаём его
        rgbA.r = LabelSlider(screenRect, rgbA.r, 0.0f, 1.0f, "Red");

        // делаем промежуток
        screenRect.y += 20;
        rgbA.g = LabelSlider(screenRect, rgbA.g, 0.0f, 1.0f, "Green");

        screenRect.y += 20;
        rgbA.b = LabelSlider(screenRect, rgbA.b, 0.0f, 1.0f, "Blue");

        screenRect.y += 20;
        rgbA.a = LabelSlider(screenRect, rgbA.a, 0.0f, 1.0f, "Alpha");

        return rgbA; // возвращаем цвет
    }    
}