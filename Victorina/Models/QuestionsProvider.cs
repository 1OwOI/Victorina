using Victorina.Models;

namespace Victorina.Data;

public static class QuestionsProvider
{
    public static List<Question> GetQuestions() => new()
    {
        // ===== Вопросы с выбором ответа (MultipleChoice) =====
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Столица Франции?",
            Options = new[] { "Лондон", "Берлин", "Париж" },
            CorrectIndex = 2
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Какая планета в Солнечной системе самая большая?",
            Options = new[] { "Земля", "Юпитер", "Сатурн", "Нептун" },
            CorrectIndex = 1
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Кто написал роман «Война и мир»?",
            Options = new[] { "Ф.М. Достоевский", "А.П. Чехов", "Л.Н. Толстой", "И.С. Тургенев" },
            CorrectIndex = 2
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Сколько цветов в радуге?",
            Options = new[] { "5", "6", "7", "8" },
            CorrectIndex = 2
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Какой химический элемент обозначается символом «O»?",
            Options = new[] { "Золото", "Кислород", "Осмий", "Олово" },
            CorrectIndex = 1
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "В каком году человек впервые полетел в космос?",
            Options = new[] { "1957", "1961", "1969", "1975" },
            CorrectIndex = 1
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Какое животное является символом мудрости?",
            Options = new[] { "Лиса", "Сова", "Змея", "Дельфин" },
            CorrectIndex = 1
        },
        new Question
        {
            Type = QestionType.MultipleChoice,
            Text = "Какой язык программирования создан компанией Microsoft?",
            Options = new[] { "Java", "Python", "C#", "Ruby" },
            CorrectIndex = 2
        },

        // ===== Вопросы с вводом текста (TextInput) =====
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Сколько будет 6 * 8?",
            CorrectText = "48"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Столица Японии?",
            CorrectText = "Токио"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Сколько дней в високосном году?",
            CorrectText = "366"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Какой газ необходим человеку для дыхания?",
            CorrectText = "Кислород"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Сколько будет 15 + 27?",
            CorrectText = "42"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Как называется самая длинная река в мире?",
            CorrectText = "Амазонка"
        },
        new Question
        {
            Type = QestionType.TextInput,
            Text = "Сколько сторон у правильного шестиугольника?",
            CorrectText = "6"
        }
    };
}