using INVENTMAN.Entities;

namespace INVENTMAN.App.Components.Items
{
    public class ItemSearch
    {
        public EquipmentType? SelectedType { get; set; } 
        public EquipmentState? SelectedState {get; set;} 

        public string Name  {get; set;} = string.Empty;
        public string Sn  {get; set;} = string.Empty;
        public string Man  {get; set;} = string.Empty;
        public string Emp  {get; set;} = string.Empty;
        public string Ven  {get; set;} = string.Empty;
        public string Invoice  {get; set;} = string.Empty;
    }
}
