using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
	 class InitSettingsVM
	 {
		  public bool MaleCompetition { get; set; } = true;
		  public bool FemaleCompetition { get; set; }
		  public bool Hrv { get; set; } = true;
		  public bool Eng { get; set; }
		  public bool Fullscreen { get; set; }
		  public bool SmallScreen { get; set; }
	 }
}
