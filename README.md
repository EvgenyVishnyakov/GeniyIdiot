<div class="text" align="center">
    <h2>Шуточная игра Гений/Идиот</h2>
</div>
<h3>Краткое объяснение</h3>
<p><em>Шуточная</em> игра для непринужденного время препровождения как одному так и в компании друзей </p>
<img src="https://github.com/user-attachments/assets/e5aadd0f-7b7c-4cae-a08e-8dac408a44b7" />
<h3>Правила игры</h3>
<img src="https://github.com/user-attachments/assets/8e937d5e-cf31-42c4-85e1-fb5a768d6b19" />
<br />
<img src="https://github.com/user-attachments/assets/b66a1a28-428d-450c-bce6-2bf6d52f1b54" />
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

    public static void Append(string Path, string value)
    {
        var writer = new StreamWriter(Path, true, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }

    public static void Replace(string Path, string value)
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

    public static void Save(string path, Password password)
    {
        var jsonData = JsonConvert.SerializeObject(password, Formatting.Indented);
        Replace(path, jsonData);
    }
<h2>Немного видео из игры</h2>

<a href="https://github.com/user-attachments/assets/d20e4a77-47db-4a6b-b80a-0049d21bfd77">Скачать видео</a>
 
<div class="text" align="center">
    <h1>Спасибо за внимание!</h2>
</div>
