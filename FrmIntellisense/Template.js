function dex_FieldName() {
    ///<summary>Programmatically fires the OnChange event for the specified field.</summary>
}

dex_crmFormObject.getAttribute.prototype = {
    getAttributeType: function() {
        /// <summary>Returns a string value that represents the type of attribute.</summary>
        /// <returns type="Object" />
    },
    getFormat: function() {
        /// <summary>Returns a string value that represents formatting options for the attribute.</summary>
        /// <returns type="String" />
    },
    getIsDirty: function() {
        /// <summary>Returns a Boolean value indicating if there are unsaved changes to the attribute value.</summary>
        /// <returns type="Boolean" />
    },
    getIsPartyList: function() {
        ///<summary>Returns a Boolean value indicating whether the lookup represents a partylist lookup.
        // Partylist lookups allow for multiple records to be set, such as the To: field for an e-mail entity record</summary>
        /// <returns type="Boolean" />
    },
    getMaxLength: function() {
        /// <summary>Returns a number indicating the maximum length of a string or memo attribute</summary>
        /// <returns type="Number" />
    },
    getName: function() {
        /// <summary>Returns a string representing the logical name of the attribute.</summary>
        /// <returns type="String" />
    },
    getParent: function() {
        /// <summary>Returns the entity object that is the parent to the attribute.</summary>
        /// <returns type="XrmTypes.Entity" />
    },
    getUserPrivilege: function() {
        /// <summary>
        ///     Returns an array of privileges that contain Boolean values indicating if the user can create, read or update
        ///     data values for an attribute.
        /// </summary>
        /// <returns type="String" />
    },
    getMax: function() {
        /// <summary>Returns a number indicating the maximum allowed value for an attribute.</summary>
        /// <returns type="Number" />
    },
    getMin: function() {
        /// <summary>Returns a number indicating the minimum allowed value for an attribute.</summary>
        /// <returns type="Number" />
    },
    getPrecision: function() {
        /// <summary>Returns the number of digits allowed to the right of the decimal point.</summary>
        /// <returns type="Number" />
    },
    fireOnChange: function() {
        /// <summary>Causes the OnChange event to occur on the attribute so that any script associated to that event can execute</summary>
        /// <returns type="Number" />
    },
    getRequiredLevel: function() {
        /// <summary>
        ///     Sets whether data is required or recommended for the attribute before the record can be saved. One of the
        ///     values 'none', 'required', 'recommended'.
        /// </summary>
        /// <returns type="String" />
    },
    setRequiredLevel: function(value) {
        ///<summary>Sets whether data is required or recommended for the attribute before the record can be saved.</summary>
        ///<param name="value" type="String"> One of the values 'none', 'required', 'recommended'.</param>
    },
    getSubmitMode: function() {
        /// <summary>
        ///     Returns a string indicating when data from the attribute will be submitted when the record is saved. One of
        ///     the values 'allways', 'never', 'dirty'.
        /// </summary>
        /// <returns type="String" />
    },
    setSubmitMode: function(value) {
        ///<summary>Sets whether data from the attribute will be submitted when the record is saved.</summary>
        ///<param name="value" type="String">One of the values 'none', 'required', 'recommended'.</param>
    },
    getValue: function() {
        /// <summary>Retrieves the data value for an attribute.</summary>
        /// <returns type="Object" />
    },
    setValue: function(value) {
        /// <summary>Sets the data value for an attribute.</summary>
        /// <param name="value" type="Object" />
    }
};
dex_crmFormObject.ui.prototype = {
    close: function() {
        /// <summary>Returns a string value that represents the type of attribute.</summary>
        /// <returns type="Object" />
    },
    getCurrentControl: function() {
        /// <summary>
        ///     Method to get the control object that currently has focus on the form. Web Resource and IFRAME controls are
        ///     not returned by this method
        /// </summary>
        /// <returns type="Object" />
    },
    getFormType: function() {
        /// <summary>Method to get the form context for the record</summary>
        /// <returns type="Number" />
    },
    clearFormNotification: function(uniqueId) {
        /// <summary>Use this method to remove form level notifications</summary>
        /// <param name="uniqueId" type="String">
        ///     A unique identifier for the message used with setFormNotification to set the
        ///     notification
        /// </param>
        /// <returns type="Boolean" />
    },
    setFormNotification: function(message, level, uniqueId) {
        ///<summary>Use this method to display form level notifications</summary>
        ///<param name="message" type="String">The text of the message</param>
        ///<param name="level" type="String">The level of the message
        // The level defines how the message will be displayed.
        // ERROR : Notification will use the system error icon.
        // WARNING : Notification will use the system warning icon.
        // INFO : Notification will use the system info icon.
        // </param>
        /// <param name="uniqueId" type="String">The text of the message </param>
        /// <returns type="Boolean" />
    },
    refreshRibbon: function() {
        /// <summary>Method to cause the ribbon to re-evaluate data that controls what is displayed in it.</summary>
        /// <returns type="None" />
    },
    getViewPortHeight: function() {
        /// <summary>Method to get the height of the viewport in pixels.</summary>
        /// <returns type="Number" />
    },
    getViewPortWidth: function() {
        /// <summary>Method to get the width of the viewport in pixels.</summary>
        /// <returns type="Number" />
    }
};
dex_crmFormObject.control.prototype = {
    getDisabled: function() {
        /// <summary>Returns whether the control is disabled..</summary>
        /// <returns type="Boolean" />
    },
    setDisabled: function(TrueOrFalse) {
        /// <summary>Sets whether the control is disabled.</summary>
        /// <param name="TrueOrFalse" type="Bool"></param>
        /// <returns type="Boolean" />
    },
    getAttribute: function() {
        /// <summary>Returns the attribute that the control is bound to.</summary>
        /// <returns type="Object" />
    },
    getControlType: function() {
        ///<summary>Returns a value that categorizes controls.</summary>
        ///Possible return values of getControlType:
        // 			Return Value  Description
        // 			standard 		A Standard control.
        // 			iframe 			An IFRAME control
        // 			lookup   		A Lookup control.
        // 			optionset 	    An OptionSet control
        // 			subgrid			A subgrid control
        // 			webresource		A web resource control
        // 			notes			A Notes control
        /// <returns type="String" />
    },
    getName: function() {
        /// <summary>Returns the name assigned to the control.</summary>
        /// <returns type="String" />
    },
    getParent: function() {
        ///<summary>Returns a reference to the section object that contains the control.</summary>
    },
    getLabel: function() {
        /// <summary>Returns the label for the control.</summary>
        /// <returns type="String" />
    },
    setLabel: function(label) {
        /// <summary>Sets the label for the control.</summary>
        /// <param name='label' type='String' />
        /// <returns type="String" />
    },
    getDefaultView: function() {
        /// <summary>Returns the Id value of the default lookup dialog view (lookup).</summary>
        /// <returns type="String" />
    },
    setDefaultView: function(viewGuid) {
        /// <summary>Sets the default view for the lookup control dialog. (lookup).</summary>
        /// <param name='viewGuid' type='String' />
        /// <returns type="String" />
    },
    setNotification: function(message, uniqueId) {
        /// <summary>Display a message near the control to indicate that data is not valid. (lookup).</summary>
        /// <param name='message' type='String' />
        /// <param name='uniqueId' type='String' />
        /// <returns type="Boolean " />
    },
    clearNotification: function(uniqueId) {
        /// <summary>Remove a message already displayed for a control. (lookup).</summary>
        /// <param name='uniqueId' type='String' />
        /// <returns type="Boolean " />
    },
    clearOptions: function() {
        ///<summary>Clears all options from an Option Set control. (lookup).</summary>
    },
    removeOption: function(number) {
        ///<summary>Removes an option from an Option Set control. (lookup).</summary>
    },
    refresh: function() {
        ///<summary>Refreshes the data displayed in a Sub-Grid. (lookup).</summary>
    },
    setFocus: function() {
        ///<summary>Sets the focus on the control. (lookup).</summary>
    },
    setShowTime: function(bool) {
        /// <summary>Specify whether a date control should show the time portion of the date. (lookup).</summary>
        /// <param name='bool' type='bool' />
    },
    getVisible: function() {
        /// <summary>Returns a value that indicates whether the control is currently visible (lookup).</summary>
        /// <returns type="bool" />
    },
    setVisible: function(bool) {
        /// <summary>Sets a value that indicates whether the control is visible. (lookup).</summary>
        /// <param name='Boolean' type='Boolean' />
    },
    getData: function() {
        /// <summary>Returns the value of the data query string parameter passed to a Silverlight web resource (lookup).</summary>
        /// <returns type="String" />
    },
    setData: function(string) {
        /// <summary>Sets the value of the data query string parameter passed to a Silverlight web resource. (lookup).</summary>
        /// <param name='string' type='string' />
        /// <returns type="string " />
    },
    getInitialUrl: function() {
        /// <summary>
        ///     Returns the default URL that an IFRAME control is configured to display. This method is not available for web
        ///     resources (lookup).
        /// </summary>
        /// <returns type="String" />
    },
    getObject: function() {
        /// <summary>Returns the object in the form that represents an I-frame or web resource. (lookup).</summary>
        /// <returns type="String" />
    },
    getSrc: function() {
        /// <summary>Returns the current URL being displayed in an IFRAME or web resource (lookup).</summary>
        /// <returns type="String" />
    },
    setSrc: function(string) {
        /// <summary>Sets the URL to be displayed in an IFRAME or web resource	(lookup).</summary>
        /// <returns type="String" />
    }
};
dex_crmFormObject.properties.prototype = {
    alertDialog: function(message, onCloseCallback) {
        /// <summary>Displays a dialog box containing an application-defined message.</summary>
        /// <param name="message" type="String"></param>
        /// <param name="onCloseCallback" type="Function"></param>
        /// <returns type="Boolean" />
    },
    confirmDialog: function(message, yesCloseCallback, noCloseCallback) {
        ///<summary>Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.</summary>
        ///<param name="message" type="String"></param>
        ///<param name="yesCloseCallback" type="Function"></param>
        ///<param name="noCloseCallback" type="Function"></param>
    },
    isActivityType: function(name) {
        /// <summary>Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.</summary>
        /// <param name="name" type="String"></param>
        /// <returns type="Boolean" />
    },
    openEntityForm: function(name, id, parameters) {
        ///<summary>Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.</summary>
        ///<param name="name" type="String"></param>
        ///<param name="id" type="String"></param>
        ///<param name="parameters" type="Object"></param>
    },
    openWebResource: function(webResourceName, webResourceData, width, height) {
        ///<summary>Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.</summary>
        ///<param name="webResourceName" type="String"></param>
        ///<param name="webResourceData" type="String"></param>
        ///<param name="width" type="Number"></param>
        ///<param name="height" type="Number"></param>
    }
};

function dex_crmFormObject() {
    this.Page = {
        getAttribute: function(name) {
            return new dex_crmFormObject.getAttribute();
        },
        ui: function() {
            return new dex_crmFormObject.ui();
        },
        getControl: function(name) {
            return new dex_crmFormObject.control();
        }
    };
    this.Utility = function() {
        this.properties = new dex_crmFormObjec.properties();
    };
    this.context = {
        client: {
            getClient: function() {
                /// <summary>Returns a value to indicate which client the script is executing in.</summary>
                /// Client      Value
                // 	    Browser		Web
                // 		Outlook		Outlook
                // 		Mobile		Mobile
                /// <returns type="String" />
            },
            getClientState: function() {
                /// <summary>Returns a value to indicate the state of the client.</summary>
                /// <returns type="String" />
            },
            getClientUrl: function() {
                /// <summary>Returns the base URL that was used to access the application.</summary>
                /// <returns type="String" />
            },
            getCurrentTheme: function() {
                /// <summary>Returns a string representing the current Microsoft Office Outlook theme chosen by the user.</summary>
                /// <returns type="String" />
            },
            getOrgLcid: function() {
                /// <summary>Returns the LCID value that represents the base language for the organization.</summary>
                /// <returns type="String" />
            },
            getOrgUniqueName: function() {
                /// <summary>Returns the unique text value of the organization’s name.</summary>
                /// <returns type="String" />
            },
            getQueryStringParameters: function() {
                /// <summary>
                ///     Returns a dictionary object of key value pairs that represent the query string arguments that were passed to
                ///     the page.
                /// </summary>
                /// <returns type="String" />
            },
            getUserId: function() {
                /// <summary>
                ///     Returns the LCID value that represents the Microsoft Dynamics CRM Language Pack that is the user selected as
                ///     their preferred language.
                /// </summary>
                /// <returns type="Number" />
            },
            getUserLcid: function() {
                /// <summary>
                ///     Returns the LCID value that represents the Microsoft Dynamics CRM Language Pack that is the user selected as
                ///     their preferred language.
                /// </summary>
                /// <returns type="Number" />
            },
            getUserName: function() {
                /// <summary>Returns the name of the current user.</summary>
                /// <returns type="String" />
            },
            getUserRoles: function() {
                /// <summary>
                ///     Returns an array of strings that represent the GUID values of each of the security roles that the user is
                ///     associated with or any teams that the user is associated with..
                /// </summary>
                /// <returns type="Array" />
            },
            isOutlookClient: function() {
                /// <summary>Returns a Boolean value indicating if the user is using Microsoft Dynamics CRM for Microsoft Office Outlook.</summary>
                /// <returns type="Boolean" />
            },
            isOutlookOnline: function() {
                /// <summary>
                ///     Returns a Boolean value that indicates whether the user is connected to the Microsoft Dynamics CRM server
                ///     while using Microsoft Dynamics CRM for Microsoft Office Outlook with Offline Access. When this function returns
                ///     false, the user is working offline without a connection to the server.
                /// </summary>
                /// <returns type="Bool" />
            },
            prependOrgName: function(path) {
                /// <summary>Prepends the organization name to the specified path.</summary>
                /// <returns type="String" />
            }
        }
    };
    this.data = {
        entity: {
            getDataXml: function() {
                /// <summary>
                ///     Returns a string representing the XML that will be sent to the server when the record is saved. Only data in
                ///     fields that have changed are set to the server.
                /// </summary>
            },
            getEntityName: function() {
                ///<summary>Returns a string representing the logical name of the entity for the record.</summary>
            },
            getId: function() {
                ///<summary>Returns a string representing the GUID id value for the record.</summary>
            },
            getIsDirty: function() {
                ///<summary>Returns a Boolean value that indicates if any fields in the form have been modified.</summary>
            },
            addOnSave: function(functionref) {
                ///<summary>Adds a function to be called when the record is saved.</summary>
                ///<param name="functionref" type="function"></param>
            },
            removeOnSave: function(functionref) {
                ///<summary>Removes a function to be called when the record is saved.</summary>
                ///<param name="functionref" type="function"></param>
            },
            getPrimaryAttributeValue: function() {},
            save: function() {},
            save: function(option) {
                ///<summary>Displays a dialog box containing an application-defined message.</summary>
                ///<param name="option" type="String"></param>
                ///save("saveandclose")
                // 				This is the equivalent of using the Save and Close command.
                // save("saveandnew")
                // 				This is the equivalent of the using the Save and New command
                /// <returns type="Boolean" />
            }
        }
    };
};

var Xrm = new dex_crmFormObject();