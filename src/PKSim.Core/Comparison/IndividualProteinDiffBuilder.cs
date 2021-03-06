﻿using PKSim.Assets;
using PKSim.Core.Model;
using OSPSuite.Core.Comparison;

namespace PKSim.Core.Comparison
{
   public class IndividualProteinDiffBuilder : DiffBuilder<IndividualProtein>
   {
      private readonly ContainerDiffBuilder _containerDiffBuilder;

      public IndividualProteinDiffBuilder(ContainerDiffBuilder containerDiffBuilder)
      {
         _containerDiffBuilder = containerDiffBuilder;
      }

      public override void Compare(IComparison<IndividualProtein> comparison)
      {
         _containerDiffBuilder.Compare(comparison);
         CompareValues(x => x.TissueLocation, PKSimConstants.UI.LocalizationInTissue, comparison);
         CompareValues(x => x.IntracellularVascularEndoLocation, PKSimConstants.UI.IntracellularVascularEndoLocation, comparison);
         CompareValues(x => x.MembraneLocation, PKSimConstants.UI.LocationOnVascularEndo, comparison);
      }
   }
}