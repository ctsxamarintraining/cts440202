// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Assignment {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class CreateFootballPlayerPage : BaseViewPage {
        
        private Image ImagePicker;
        
        private TapGestureRecognizer ImagePickerTapGesture;
        
        private Entry FirstNamelbl;
        
        private Entry LastNamelbl;
        
        private DatePicker DateOfBirthPicker;
        
        private Picker CountryPicker;
        
        private Editor DescriptionEditor;
        
        private Button SavePlayerProfileBTN;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(CreateFootballPlayerPage));
            ImagePicker = this.FindByName <Image>("ImagePicker");
            ImagePickerTapGesture = this.FindByName <TapGestureRecognizer>("ImagePickerTapGesture");
            FirstNamelbl = this.FindByName <Entry>("FirstNamelbl");
            LastNamelbl = this.FindByName <Entry>("LastNamelbl");
            DateOfBirthPicker = this.FindByName <DatePicker>("DateOfBirthPicker");
            CountryPicker = this.FindByName <Picker>("CountryPicker");
            DescriptionEditor = this.FindByName <Editor>("DescriptionEditor");
            SavePlayerProfileBTN = this.FindByName <Button>("SavePlayerProfileBTN");
        }
    }
}