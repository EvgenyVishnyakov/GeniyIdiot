<div class="text" align="center">
    <h2>Шуточная игра Гений/Идиот</h2>
</div>
<h3>Краткое объяснение</h3>
<p><em>Шуточная</em> игра для непринужденного время препровождения как одному так и в компании друзей </p>
<img src="https://github.com/user-attachments/assets/e5aadd0f-7b7c-4cae-a08e-8dac408a44b7" />
<h3>Правила игры</h3>
<img src="https://github.com/user-attachments/assets/8e937d5e-cf31-42c4-85e1-fb5a768d6b19" />
<br />
<p>По итогам игры участник игры получает <b>"шуточный"</b> итог игры, над которым все могут посмеяться</p>
<p>Взяв на себя функции администратора пользователь может изменять и дополнять вопросы для изменения игры</p>
<h3>Архитектурная часть</h3>
<img src="https://github.com/user-attachments/assets/c9da1e9f-2c1f-4989-93e1-8c8dc38a4a06" />
<p>Работа выполнена с использованием общей бибилиотеки в коде</p>
<p>При разработки данной игры я прошел несколько важных шагов в изучении языка с#</p>
<ul>
    <li>Использование знаний по ООП для разделения сущностей и логики работы кода</li>
    <li>Использвоание формата Json для сохранения результатов игры</li>
    <li>Работа с файловой системой</li>
    <li>Проверка на валидность данных, использование try catch</li>
    <li>Возможность расширения списка вопросов и ответов для разнообразия игры</li>
</ul>
<h5>Особенно хотел бы отметить код для сохрарения в формате JSON</h5>
public class FileProvider
{
    public static void Write(string Path, string value)
    {
        var writer = new StreamWriter(Path, false, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }

    public static string GetValue(string Path)
    {
        var reader = new StreamReader(Path, Encoding.UTF8);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }

    public static bool Exists(string Path)
    {
        return File.Exists(Path);
    }
}

