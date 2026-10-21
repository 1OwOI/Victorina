namespace Victorina.Models;

public enum QestionType 
{
	MultipleChoice,
	TextInput
}
public class Question
{
	public string Text { get; set; } = string.Empty;
	public string[] Options { get; set; } = Array.Empty<string>();
	public int CorrectIndex { get; set; }
	public string CorrectText { get; set; } = string.Empty;
	public QestionType Type { get; set; } = QestionType.MultipleChoice;
}