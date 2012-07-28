using System;
using DevExpress.ExpressApp.StateMachine;
using DevExpress.ExpressApp.StateMachine.NonPersistent;

namespace ProjectManagement_1.Module.BusinessObjects {

	public class StatusStateMachine : StateMachine<Releases>, IStateMachineUISettings {

		private IState notStart_State;

		public StatusStateMachine() {
			notStart_State = new State(this, Status.NotStarted);
			IState inProgressState = new State(this, "In Progress", Status.InProgress);
			IState problemState = new State(this, Status.Problem);
			IState finishedState = new State(this, Status.Finished);

			#region Add Transitions
			notStart_State.Transitions.Add(new Transition(inProgressState));
			notStart_State.Transitions.Add(new Transition(problemState));
			
			problemState.Transitions.Add(new Transition(inProgressState));

			inProgressState.Transitions.Add(new Transition(finishedState));
			inProgressState.Transitions.Add(new Transition(problemState));
			#endregion

			States.Add(notStart_State);
			States.Add(inProgressState);
			States.Add(problemState);
			States.Add(finishedState);

		}

		public override string Name {
			get { return "Change status to"; }
		}
		//... 
		public override string StatePropertyName {
			get { return "Status"; }
		}

		public override IState StartState {
			get { return notStart_State; }
		}

		//... 
		public bool ExpandActionsInDetailView {
			get { return true; }
		}

	}

}
