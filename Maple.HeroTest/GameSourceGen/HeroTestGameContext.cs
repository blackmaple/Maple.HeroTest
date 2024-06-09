using Maple.HeroTest.GameModel.Rabi;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.HeroTest
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]


    [MonoCollectorType(typeof(InventoryManager))]
    [MonoCollectorType(typeof(InventoryData))]
    [MonoCollectorType(typeof(DepotData))]
    public partial class HeroTestGameContext
    {

    }
}
