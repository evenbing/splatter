
// This file has been generated by the GUI designer. Do not modify.
namespace BugzillaInterface
{
	public partial class PeopleFilterWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::BugzillaInterface.SensitiveTextBox assignedTextBox;

		private global::Gtk.Label GtkLabel1;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment1;

		private global::BugzillaInterface.SensitiveTextBox reportedTextBox;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment2;

		private global::BugzillaInterface.SensitiveTextBox qaTextBox;

		private global::Gtk.Label GtkLabel23;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BugzillaInterface.PeopleFilterWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BugzillaInterface.PeopleFilterWidget";
			// Container child BugzillaInterface.PeopleFilterWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.assignedTextBox = new global::BugzillaInterface.SensitiveTextBox ();
			this.assignedTextBox.Events = ((global::Gdk.EventMask)(256));
			this.assignedTextBox.Name = "assignedTextBox";
			this.GtkAlignment.Add (this.assignedTextBox);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Assigned to</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel1;
			this.vbox1.Add (this.frame1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.reportedTextBox = new global::BugzillaInterface.SensitiveTextBox ();
			this.reportedTextBox.Events = ((global::Gdk.EventMask)(256));
			this.reportedTextBox.Name = "reportedTextBox";
			this.GtkAlignment1.Add (this.reportedTextBox);
			this.frame2.Add (this.GtkAlignment1);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Reported by</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel6;
			this.vbox1.Add (this.frame2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.qaTextBox = new global::BugzillaInterface.SensitiveTextBox ();
			this.qaTextBox.Events = ((global::Gdk.EventMask)(256));
			this.qaTextBox.Name = "qaTextBox";
			this.GtkAlignment2.Add (this.qaTextBox);
			this.frame3.Add (this.GtkAlignment2);
			this.GtkLabel23 = new global::Gtk.Label ();
			this.GtkLabel23.Name = "GtkLabel23";
			this.GtkLabel23.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>QA Contact</b>");
			this.GtkLabel23.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel23;
			this.vbox1.Add (this.frame3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame3]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
