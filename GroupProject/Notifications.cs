using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace BudgetPlanner
{

	public class Notifications
	{

		public static void Notification(string text1, string text2)
		{
			Notifications notifications = new Notifications();

			new ToastContentBuilder()
	   .AddArgument("action", "viewConversation")
	   .AddArgument("conversationID", 9813)
	   .AddText(text1)
	   .AddText(text2)
	   .Show();
		}
	}
}
