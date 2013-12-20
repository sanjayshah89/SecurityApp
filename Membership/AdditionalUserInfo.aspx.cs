﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecurityApp.Membership
{
    public partial class AdditionalUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UserProfileDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            // Get a reference to the currently logged on user
            System.Web.Security.MembershipUser currentUser = System.Web.Security.Membership.GetUser();

            // Determine the currently logged on user's UserId value
            Guid currentUserId = (Guid)currentUser.ProviderUserKey;

            // Assign the currently logged on user's UserId to the @UserId parameter
            e.Command.Parameters["@UserId"].Value = currentUserId;
        }

        protected void UserProfile_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            SettingsUpdatedMessage.Visible = true;
        }
    }
}