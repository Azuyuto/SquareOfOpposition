using Newtonsoft.Json;
using SquareOfOpposition.Common.Enum;
using SquareOfOpposition.Web.Models;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.ViewModels;
using System.Text.Json.Nodes;

namespace SquareOfOpposition.Web.Helpers
{
    public static class WebsiteHelper
    {
        public static string GetCytoscapeElementsByStates(List<StateViewModel> states)
        {
            var json = new CytoscapeElements();
            foreach (var state in states)
            {
                json.nodes.Add(new Node()
                {
                    data = new CytoscapeData() { 
                        id = state.Id.ToString(),
                        name = GetStateSentance(state.Square, state.StateType),
                        color = state.Square.Color
                    }
                });

                foreach(var transition in state.StateTransition)
                {
                    json.edges.Add(new Edge()
                    {
                        data = new CytoscapeData()
                        {
                            name = transition.Name,
                            source = transition.PickupStateId.ToString(),
                            target = transition.DestinationStateId.ToString()
                        }
                    });
                }
            }

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };

            return JsonConvert.SerializeObject(json, settings); ;
        }

        public static string GetStateSentance(Square square, StateTypeEnum type)
        {
            switch (type)
            {
                case StateTypeEnum.AI:
                    return square.SentenceA + " & " + square.SentenceI;
                case StateTypeEnum.IO:
                    return square.SentenceI + " & " + square.SentenceO;
                case StateTypeEnum.EO:
                    return square.SentenceE + " & " + square.SentenceO;
                default:
                    return "";
            }
        }
    }
}
