using MudBlazor;

namespace Villawhatever.Resources
{
	// Sync defaults up with MudBlazor so we don't have to define
	// every single thing in config, just stuff we intend to change.
	// (see https://mudblazor.com/customization/default-theme)
	public class ColorConfig
    {
		public Palette GetPalette()
        {
			return new Palette
			{
				Black = Black,
				White = White,
				Primary = Primary,
				PrimaryContrastText = PrimaryContrastText,
				Secondary = Secondary,
				Tertiary = Tertiary,
				Info = Info,
				Success = Success,
				Warning = Warning,
				Error = Error,
				Dark = Dark,
				TextPrimary = TextPrimary,
				TextSecondary = TextSecondary,
				TextDisabled = TextDisabled,
				ActionDefault = ActionDefault,
				ActionDisabled = ActionDisabled,
				ActionDisabledBackground = ActionDisabledBackground,
				Background = Background,
				BackgroundGrey = BackgroundGrey,
				Surface = Surface,
				DrawerBackground = DrawerBackground,
				DrawerText = DrawerText,
				DrawerIcon = DrawerIcon,
				AppbarBackground = AppbarBackground,
				AppbarText = AppbarText,
				LinesDefault = LinesDefault,
				LinesInputs = LinesInputs,
				Divider = Divider,
				GrayDefault = GrayDefault,
				GrayLight = GrayLight,
				GrayLighter = GrayLighter,
				GrayDark = GrayDark,
				GrayDarker = GrayDarker
			};
		}

        public string Black { get; set; } = "#000000";
        public string White { get; set; } = "#FFFFFF";
        public string Primary { get; set; } = "#594AE2";
		public string PrimaryContrastText { get; set; } = "#FFFFFF";
		public string Secondary { get; set; } = "#625192";
        public string Tertiary { get; set; } = "#1EC8A5";
        public string Info { get; set; } = "#2196F3";
        public string Success { get; set; } = "#00C853";
        public string Warning { get; set; } = "#FF9800";
        public string Error { get; set; } = "#F44336";
        public string Dark { get; set; } = "#424242";
        public string TextPrimary { get; set; } = "#424242";
        public string TextSecondary { get; set; } = "rgba(0,0,0, 0.54)";
		public string TextDisabled { get; set; } = "rgba(0,0,0, 0.38)";
		public string ActionDefault { get; set; } = "rgba(0,0,0, 0.54)";
		public string ActionDisabled { get; set; } = "rgba(0,0,0, 0.26)";
		public string ActionDisabledBackground { get; set; } = "rgba(0,0,0, 0.12)";
		public string Background { get; set; } = "#FFFFFF";
		public string BackgroundGrey { get; set; } = "#F5F5F5";
		public string Surface { get; set; } = "#FFFFFF";
		public string DrawerBackground { get; set; } = "#FFFFFF";
		public string DrawerText { get; set; } = "#424242";
		public string DrawerIcon { get; set; } = "#616161";
		public string AppbarBackground { get; set; } = "#594AE2";
		public string AppbarText { get; set; } = "#FFFFFF";
		public string LinesDefault { get; set; } = "rgba(0,0,0, 0.12)";
		public string LinesInputs { get; set; } = "#BDBDBD";
		public string Divider { get; set; } = "#E0E0E0";
		public string DividerLight { get; set; } = "rgba(0,0,0, 0.8)";
		public string HoverOpacity { get; set; } = "0.06";
		public string GrayDefault { get; set; } = "#9E9E9E";
		public string GrayLight { get; set; } = "#BDBDBD";
		public string GrayLighter { get; set; } = "#E0E0E0";
		public string GrayDark { get; set; } = "#757575";
		public string GrayDarker { get; set; } = "#616161";
    }
}
