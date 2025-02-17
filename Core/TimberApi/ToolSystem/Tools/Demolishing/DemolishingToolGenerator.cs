using System.Collections.Generic;
using Newtonsoft.Json;
using TimberApi.SpecificationSystem;
using TimberApi.SpecificationSystem.SpecificationTypes;

namespace TimberApi.ToolSystem.Tools.Demolishing
{
    public class DemolishingToolGenerator : ISpecificationGenerator
    {
        public IEnumerable<ISpecification> Generate()
        {
            yield return CreateDemolishingToolGroup();
            yield return DemolishableSelectionTool();
            yield return DemolishableUnselectionTool();
            yield return BuildingDeconstructionTool();
            yield return EntityBlockObjectDeletionTool();
        }

        private static GeneratedSpecification EntityBlockObjectDeletionTool()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Id = "EntityBlockObjectDeletion",
                GroupId = "Demolishing",
                Type = "EntityBlockObjectDeletionTool",
                Layout = "Default",
                Order = 20,
                NameLocKey = "CAN NOT BE MODIFIED",
                DescriptionLocKey = "CAN NOT BE MODIFIED",
                Icon = "Sprites/BottomBar/DeleteObjectIcon",
                DevMode = false,
                Hidden = false,
            });

            return new GeneratedSpecification(json, "EntityBlockObjectDeletion", "ToolSpecification");
        }

        private static GeneratedSpecification BuildingDeconstructionTool()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Id = "BuildingDeconstruction",
                GroupId = "Demolishing",
                Type = "BuildingDeconstructionTool",
                Layout = "Default",
                Order = 10,
                NameLocKey = "CAN NOT BE MODIFIED",
                DescriptionLocKey = "CAN NOT BE MODIFIED",
                Icon = "Sprites/BottomBar/DeleteObjectIcon",
                DevMode = false,
                Hidden = false,
            });

            return new GeneratedSpecification(json, "BuildingDeconstruction", "ToolSpecification");
        }

        private static GeneratedSpecification DemolishableSelectionTool()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Id = "DemolishableSelection",
                GroupId = "Demolishing",
                Type = "DemolishableSelectionTool",
                Layout = "Default",
                Order = 0,
                NameLocKey = "CAN NOT BE MODIFIED",
                DescriptionLocKey = "CAN NOT BE MODIFIED",
                Icon = "Sprites/BottomBar/DemolishResourcesTool",
                DevMode = false,
                Hidden = false,
            });

            return new GeneratedSpecification(json, "DemolishableSelection", "ToolSpecification");
        }

        private static GeneratedSpecification DemolishableUnselectionTool()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Id = "DemolishableUnselection",
                GroupId = "Demolishing",
                Type = "DemolishableUnselectionTool",
                Layout = "Default",
                Order = 1000,
                NameLocKey = "CAN NOT BE MODIFIED",
                DescriptionLocKey = "CAN NOT BE MODIFIED",
                Icon = "Sprites/BottomBar/CancelToolIcon",
                DevMode = false,
                Hidden = false,
            });

            return new GeneratedSpecification(json, "DemolishableUnselection", "ToolSpecification");
        }

        private static GeneratedSpecification CreateDemolishingToolGroup()
        {
            var json = JsonConvert.SerializeObject(new
            {
                Id = "Demolishing",
                Layout = "Blue",
                Order = 40,
                Type = "ConstructionModeToolGroup",
                NameLocKey = "ToolGroups.Demolishing",
                Icon = "Sprites/BottomBar/DeleteGroupIcon",
                Section = "BottomBar",
                DevMode = false,
                Hidden = false,
                FallbackGroup = false,
                GroupInformation = new
                {
                    BottomBarSection = 0
                }
            });


            return new GeneratedSpecification(json, "Demolishing", "ToolGroupSpecification");
        }
    }
}