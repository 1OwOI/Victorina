using Victorina.Data;
using Victorina.Models;

namespace Victorina.Pages;

public partial class QuizPage : ContentPage
{
	private List<Question> _questions = QuestionsProvider.GetQuestions();
	private int _currentIndex;
	private int _score;
	public QuizPage()
	{
		InitializeComponent();
		LoadQuestion();
	}
	private void LoadQuestion() 
	{
		var q = _questions[_currentIndex];
		QuestionLabel.Text = q.Text;
		OptionsLayout.Children.Clear();
		AnswerEntry.Text = string.Empty;
		if (q.Type == QestionType.MultipleChoice)
		{
			OptionsLayout.IsVisible = true;
			InputLayout.IsVisible = false;

			for (int i = 0; i < q.Options.Length; i++)
			{
				int index = i;
				var button = new Button
				{
					Text = q.Options[i],
					HorizontalOptions = LayoutOptions.Fill
				};
				button.Clicked += (_, _) => OnAnswerSelected(index);
				OptionsLayout.Children.Add(button);
			}
		}
		else if (q.Type == QestionType.TextInput)
		{
			OptionsLayout.IsVisible = false;
			InputLayout.IsVisible = true;
		}
		
	}

	private async void OnAnswerSelected(int selectedIndex) 
	{
		var q = _questions[_currentIndex];
		if (selectedIndex == q.CorrectIndex)
			_score++;

		await NextQuestionAsync();
	}

	private async void OnSubmitTextClicked(object sender, EventArgs e)
	{
		var q = _questions[_currentIndex];
		string userAnswer = AnswerEntry.Text?.Trim() ?? string.Empty;

		if (string.Equals(userAnswer, q.CorrectText, StringComparison.OrdinalIgnoreCase))
		{
			_score++;
		}
		await NextQuestionAsync();
	}

    private async Task NextQuestionAsync()  
	{
		_currentIndex++;

		if (_currentIndex < _questions.Count) 
		{
			LoadQuestion();
		}
		else 
		{
			await Shell.Current.GoToAsync($"result?score={_score}&total={_questions.Count}");
		}
	}
}