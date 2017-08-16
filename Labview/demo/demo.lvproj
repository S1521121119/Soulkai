<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="16008000">
	<Property Name="NI.LV.All.SourceOnly" Type="Bool">false</Property>
	<Property Name="SMProvider.SMVersion" Type="Int">201310</Property>
	<Item Name="My Computer" Type="My Computer">
		<Property Name="IOScan.Faults" Type="Str"></Property>
		<Property Name="IOScan.NetVarPeriod" Type="UInt">100</Property>
		<Property Name="IOScan.NetWatchdogEnabled" Type="Bool">false</Property>
		<Property Name="IOScan.Period" Type="UInt">10000</Property>
		<Property Name="IOScan.PowerupMode" Type="UInt">0</Property>
		<Property Name="IOScan.Priority" Type="UInt">9</Property>
		<Property Name="IOScan.ReportModeConflict" Type="Bool">true</Property>
		<Property Name="IOScan.StartEngineOnDeploy" Type="Bool">false</Property>
		<Property Name="NI.SortType" Type="Int">3</Property>
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Support VIs" Type="Folder">
			<Property Name="NI.SortType" Type="Int">3</Property>
		</Item>
		<Item Name="Type Definitions" Type="Folder">
			<Item Name="UI Data.ctl" Type="VI" URL="../controls/UI Data.ctl"/>
		</Item>
		<Item Name="0.GUI" Type="Folder"/>
		<Item Name="1.DIO" Type="Folder"/>
		<Item Name="2.Error" Type="Folder"/>
		<Item Name="3.SubVI" Type="Folder">
			<Item Name="Message Queue" Type="Folder"/>
			<Item Name="User Event - Stop" Type="Folder">
				<Item Name="User Event - Stop.lvlib" Type="Library" URL="../3.SubVI/User Event - Stop/User Event - Stop.lvlib"/>
			</Item>
			<Item Name="Check Loop Error1.vi" Type="VI" URL="../3.SubVI/Check Loop Error1.vi"/>
			<Item Name="check_done.vi" Type="VI" URL="../3.SubVI/check_done.vi"/>
			<Item Name="Error Handler - Event Handling Loop.vi" Type="VI" URL="../3.SubVI/Error Handler - Event Handling Loop.vi"/>
			<Item Name="Error Handler - Message Handling Loop.vi" Type="VI" URL="../3.SubVI/Error Handler - Message Handling Loop.vi"/>
			<Item Name="Queue.vi" Type="VI" URL="../3.SubVI/Queue.vi"/>
			<Item Name="User Event Handle.vi" Type="VI" URL="../3.SubVI/User Event Handle.vi"/>
			<Item Name="User Event star.vi" Type="VI" URL="../3.SubVI/User Event star.vi"/>
			<Item Name="User Event Stop.vi" Type="VI" URL="../3.SubVI/User Event Stop.vi"/>
			<Item Name="Message Queue.lvlib" Type="Library" URL="../3.SubVI/Message Queue/Message Queue.lvlib"/>
			<Item Name="Line_FGV.vi" Type="VI" URL="../3.SubVI/Line_FGV.vi"/>
		</Item>
		<Item Name="4.Class" Type="Folder"/>
		<Item Name="5.Process" Type="Folder"/>
		<Item Name="19.TCP" Type="Folder"/>
		<Item Name="FindHome" Type="Folder"/>
		<Item Name="Main.vi" Type="VI" URL="../Main.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="General Error Handler Core CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler Core CORE.vi"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
				<Item Name="LVPointTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVPointTypeDef.ctl"/>
			</Item>
			<Item Name="user.lib" Type="Folder">
				<Item Name="Acm_GetAvailableDevs.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/Device Common.llb/Acm_GetAvailableDevs.vi"/>
				<Item Name="FT_DevAxesCount.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/Device Common.llb/FT_DevAxesCount.vi"/>
				<Item Name="Acm_AxOpen.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxOpen.vi"/>
				<Item Name="Acm_SetProperty.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/Device API/Device API.llb/Acm_SetProperty.vi"/>
				<Item Name="Acm_AxSetExtDrive.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis External Driver/Axis External Driver.llb/Acm_AxSetExtDrive.vi"/>
				<Item Name="Acm_AxGetCmdPosition.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxGetCmdPosition.vi"/>
				<Item Name="Acm_AxGetState.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxGetState.vi"/>
				<Item Name="Acm_AxGetMotionIO.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis MotionIO&amp;Status/Axis MotionIO&amp;Status.llb/Acm_AxGetMotionIO.vi"/>
				<Item Name="Acm_AxSetSvOn.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxSetSvOn.vi"/>
				<Item Name="Acm_AxSetCmdPosition.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxSetCmdPosition.vi"/>
				<Item Name="Acm_AxResetError.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxResetError.vi"/>
				<Item Name="Acm_AxClose.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Axis/Axis Common.llb/Acm_AxClose.vi"/>
				<Item Name="Acm_DevOpen.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/Device Common.llb/Acm_DevOpen.vi"/>
				<Item Name="Acm_DevClose.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/Device Common.llb/Acm_DevClose.vi"/>
				<Item Name="Acm_GetProperty.vi" Type="VI" URL="/&lt;userlib&gt;/Advantech Common Motion/Device/FT_DevAxesCount Folder/Device API/Device API.llb/Acm_GetProperty.vi"/>
			</Item>
			<Item Name="FP Origin(初始化).vi" Type="VI" URL="../../../../Desktop/新增資料夾/3.SubVI/FP Origin(初始化).vi"/>
			<Item Name="Check Loop Error.vi" Type="VI" URL="../3.SubVI/Check Loop Error.vi"/>
			<Item Name="Queue1.vi" Type="VI" URL="../3.SubVI/Queue1.vi"/>
			<Item Name="check_done(第二站).vi" Type="VI" URL="../3.SubVI/check_done(第二站).vi"/>
			<Item Name="Axe_card.vi" Type="VI" URL="../5.Process/Axe_card.vi"/>
			<Item Name="ADVMOT.dll" Type="Document" URL="ADVMOT.dll">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build">
			<Item Name="Main Application" Type="EXE">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{51D186D8-2FD9-4F4B-8F36-40D68E57FFBC}</Property>
				<Property Name="App_INI_GUID" Type="Str">{F8BAE070-8383-465E-800B-3DF9D752A65B}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{96FCFFEE-92FF-41D7-8A5C-2E1B7D4F08B1}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Main Application</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds/NI_AB_PROJECTNAME/Main Application</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToCommon</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{9236DFC5-A1BE-45C5-93F4-A12737594CB8}</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">Main.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/NI_AB_PROJECTNAME/Main Application/Main.exe</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/NI_AB_PROJECTNAME/Main Application/data</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Source[0].itemID" Type="Str">{E7BFF366-DAB8-43B4-AA23-0662F14B8EC9}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/Main.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
				<Property Name="TgtF_fileDescription" Type="Str">Main Application</Property>
				<Property Name="TgtF_internalName" Type="Str">Main Application</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright c 2012 </Property>
				<Property Name="TgtF_productName" Type="Str">Main Application</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{8D31CF1E-BFEE-4FAB-AC90-991853A95B09}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">Main.exe</Property>
			</Item>
		</Item>
	</Item>
</Project>
