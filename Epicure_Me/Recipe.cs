using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicure_Me
{
	public class Recipe
	{
		private bool isFavorite;
		public bool IsFavorite
		{
			get { return isFavorite; }
			set
			{
				if (isFavorite != value)
				{
					isFavorite = value;
					// You can also trigger property changed event here if needed
				}
			}
		}
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public string ImageType { get; set; }
		public bool Vegetarian { get; set; }
		public bool Vegan { get; set; }
		public bool GlutenFree { get; set; }
		public bool DairyFree { get; set; }
		public bool VeryHealthy { get; set; }
		public bool Cheap { get; set; }
		public bool VeryPopular { get; set; }
		public bool Sustainable { get; set; }
		public bool LowFodmap { get; set; }
		public int WeightWatcherSmartPoints { get; set; }
		public string Gaps { get; set; }
		public int PreparationMinutes { get; set; }
		public int CookingMinutes { get; set; }
		public int AggregateLikes { get; set; }
		public int HealthScore { get; set; }
		public string CreditsText { get; set; }
		public string License { get; set; }
		public string SourceName { get; set; }
		public double PricePerServing { get; set; }
		public List<ExtendedIngredient> ExtendedIngredients { get; set; }
		public int Servings { get; set; }
		public string SourceUrl { get; set; }
		public string Summary { get; set; }
		public List<string> Cuisines { get; set; }
		public List<string> DishTypes { get; set; }
		public List<string> Diets { get; set; }
		public List<string> Occasions { get; set; }
		public string Instructions { get; set; }
		public List<AnalyzedInstruction> AnalyzedInstructions { get; set; }
		public int ReadyInMinutes { get; set; }
	}

	public class ExtendedIngredient
	{
		public int Id { get; set; }
		public string Aisle { get; set; }
		public string Image { get; set; }
		public string Consistency { get; set; }
		public string Name { get; set; }
		public string NameClean { get; set; }
		public string Original { get; set; }
		public string OriginalName { get; set; }
		public double Amount { get; set; }
		public string Unit { get; set; }
		public List<string> Meta { get; set; }
		public Measures Measures { get; set; }
	}

	public class Measures
	{
		public Measure Us { get; set; }
		public Measure Metric { get; set; }
	}

	public class Measure
	{
		public double Amount { get; set; }
		public string UnitShort { get; set; }
		public string UnitLong { get; set; }
	}

	public class AnalyzedInstruction
	{
		public string Name { get; set; }
		public List<InstructionStep> Steps { get; set; }
	}

	public class InstructionStep
	{
		public int Number { get; set; }
		public string Step { get; set; }
		public List<InstructionIngredient> Ingredients { get; set; }
		public List<InstructionEquipment> Equipment { get; set; }
		public Length Length { get; set; }
	}

	public class InstructionIngredient
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LocalizedName { get; set; }
		public string Image { get; set; }
	}

	public class InstructionEquipment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LocalizedName { get; set; }
		public string Image { get; set; }
	}

	public class Length
	{
		public int Number { get; set; }
		public string Unit { get; set; }
	}

	public class RecipeApiResponse
	{
		public int Offset { get; set; }
		public int Number { get; set; }
		public List<Recipe> Recipes { get; set; }
		public int TotalResults { get; set; }


	}
	
	
	
	
}
