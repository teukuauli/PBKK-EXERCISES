namespace Astronomy.Pages;
[QueryProperty(nameof(DataName), "dataName")]
public partial class ProfileDetailsPage  : ContentPage
{

    public ProfileDetailsPage()
    {
        InitializeComponent();
    }
    string dataName;
    public string DataName
    {
        get => dataName;
        set
        {
            dataName = value;

            // this is a custom function to update the UI immediately
            UpdateDataNameUI(dataName);
        }
    }

    void UpdateDataNameUI(string dataName)
    {
        ProfileDetails body = FindDataName(dataName);

        lblTitle.Text = body.Title;
        lblName.Text = body.Name;
        lblNrp.Text = body.Nrp;

    }

    ProfileDetails FindDataName(string ProfileDetailsData)
    {
        return ProfileDetailsData switch
        {
            "profile" => StudentData.profile1,
            _ => throw new ArgumentException()
        };
    }


}
