namespace StudentDBAppnew;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnSearchClicked(object sender, EventArgs e)
    {
        var s = StudentRepository.GetStudentById(1);

        Title.Text = s.Name;


    }

    private void OnAddStudentClicked(object sender, EventArgs e)
    {
        //need student data
        Student s1 = new Student("Dana", "d@gmail.com");

        //access the list
        //Add to the list 
        StudentRepository.addStudent(s1);
        Title.Text = s1.Id.ToString();


    }


    private void OnStudentListClicked(object sender, EventArgs e)
    {



        DisplayAlert("StudentList BTN clicked", " See the entire list of student", "Ok");

    }
}


