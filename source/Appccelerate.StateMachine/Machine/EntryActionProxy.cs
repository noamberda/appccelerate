using Appccelerate.StateMachine.Machine.ActionHolders;

namespace Appccelerate.StateMachine.Machine
{
    public class EntryActionProxy : IEntryActionProxy
    {
        private readonly IActionHolder _actionHolder;
        private readonly bool _executeOnStart;

        public EntryActionProxy(IActionHolder actionHolder, bool executeOnStart)
        {
            _actionHolder = actionHolder;
            _executeOnStart = executeOnStart;
        }

        public IActionHolder ActionHolder
        {
            get { return _actionHolder; }
        }

        public bool ExecuteOnStart
        {
            get { return _executeOnStart; }
        }
    }
}