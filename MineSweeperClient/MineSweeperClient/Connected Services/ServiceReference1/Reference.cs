﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MineSweeperClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserExistsFault", Namespace="http://schemas.datacontract.org/2004/07/MineSweeperServer")]
    [System.SerializableAttribute()]
    public partial class UserExistsFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/MineSweeperServer")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MineSweeperClient.ServiceReference1.Game[] GamesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MineSweeperClient.ServiceReference1.Game[] Games {
            get {
                return this.GamesField;
            }
            set {
                if ((object.ReferenceEquals(this.GamesField, value) != true)) {
                    this.GamesField = value;
                    this.RaisePropertyChanged("Games");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/MineSweeperServer")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime GameDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MineSweeperClient.ServiceReference1.Player[] PlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WinnerField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime GameDate {
            get {
                return this.GameDateField;
            }
            set {
                if ((this.GameDateField.Equals(value) != true)) {
                    this.GameDateField = value;
                    this.RaisePropertyChanged("GameDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Loser {
            get {
                return this.LoserField;
            }
            set {
                if ((object.ReferenceEquals(this.LoserField, value) != true)) {
                    this.LoserField = value;
                    this.RaisePropertyChanged("Loser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MineSweeperClient.ServiceReference1.Player[] Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Tie {
            get {
                return this.TieField;
            }
            set {
                if ((this.TieField.Equals(value) != true)) {
                    this.TieField = value;
                    this.RaisePropertyChanged("Tie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Winner {
            get {
                return this.WinnerField;
            }
            set {
                if ((object.ReferenceEquals(this.WinnerField, value) != true)) {
                    this.WinnerField = value;
                    this.RaisePropertyChanged("Winner");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMineSweeperService", CallbackContract=typeof(MineSweeperClient.ServiceReference1.IMineSweeperServiceCallback))]
    public interface IMineSweeperService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/ClientConnected", ReplyAction="http://tempuri.org/IMineSweeperService/ClientConnectedResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineSweeperClient.ServiceReference1.UserExistsFault), Action="http://tempuri.org/IMineSweeperService/ClientConnectedUserExistsFaultFault", Name="UserExistsFault", Namespace="http://schemas.datacontract.org/2004/07/MineSweeperServer")]
        void ClientConnected(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/ClientConnected", ReplyAction="http://tempuri.org/IMineSweeperService/ClientConnectedResponse")]
        System.Threading.Tasks.Task ClientConnectedAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/ClientDisconnected", ReplyAction="http://tempuri.org/IMineSweeperService/ClientDisconnectedResponse")]
        void ClientDisconnected(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/ClientDisconnected", ReplyAction="http://tempuri.org/IMineSweeperService/ClientDisconnectedResponse")]
        System.Threading.Tasks.Task ClientDisconnectedAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerExists", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerExistsResponse")]
        bool PlayerExists(string player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerExists", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerExistsResponse")]
        System.Threading.Tasks.Task<bool> PlayerExistsAsync(string player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/IsLegalUser", ReplyAction="http://tempuri.org/IMineSweeperService/IsLegalUserResponse")]
        bool IsLegalUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/IsLegalUser", ReplyAction="http://tempuri.org/IMineSweeperService/IsLegalUserResponse")]
        System.Threading.Tasks.Task<bool> IsLegalUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/EnterPlayerToDB", ReplyAction="http://tempuri.org/IMineSweeperService/EnterPlayerToDBResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MineSweeperClient.ServiceReference1.UserExistsFault), Action="http://tempuri.org/IMineSweeperService/EnterPlayerToDBUserExistsFaultFault", Name="UserExistsFault", Namespace="http://schemas.datacontract.org/2004/07/MineSweeperServer")]
        void EnterPlayerToDB(MineSweeperClient.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/EnterPlayerToDB", ReplyAction="http://tempuri.org/IMineSweeperService/EnterPlayerToDBResponse")]
        System.Threading.Tasks.Task EnterPlayerToDBAsync(MineSweeperClient.ServiceReference1.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SendRequest", ReplyAction="http://tempuri.org/IMineSweeperService/SendRequestResponse")]
        void SendRequest(string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SendRequest", ReplyAction="http://tempuri.org/IMineSweeperService/SendRequestResponse")]
        System.Threading.Tasks.Task SendRequestAsync(string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetAllPlayers", ReplyAction="http://tempuri.org/IMineSweeperService/GetAllPlayersResponse")]
        string[][] GetAllPlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetAllPlayers", ReplyAction="http://tempuri.org/IMineSweeperService/GetAllPlayersResponse")]
        System.Threading.Tasks.Task<string[][]> GetAllPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetAllGames", ReplyAction="http://tempuri.org/IMineSweeperService/GetAllGamesResponse")]
        string[][] GetAllGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetAllGames", ReplyAction="http://tempuri.org/IMineSweeperService/GetAllGamesResponse")]
        System.Threading.Tasks.Task<string[][]> GetAllGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/DenyGameRequest", ReplyAction="http://tempuri.org/IMineSweeperService/DenyGameRequestResponse")]
        void DenyGameRequest(string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/DenyGameRequest", ReplyAction="http://tempuri.org/IMineSweeperService/DenyGameRequestResponse")]
        System.Threading.Tasks.Task DenyGameRequestAsync(string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/StartGameServer", ReplyAction="http://tempuri.org/IMineSweeperService/StartGameServerResponse")]
        void StartGameServer(string fromPlayer, string toPlayer, int size, int mines, System.Tuple<int, int>[] minesPositions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/StartGameServer", ReplyAction="http://tempuri.org/IMineSweeperService/StartGameServerResponse")]
        System.Threading.Tasks.Task StartGameServerAsync(string fromPlayer, string toPlayer, int size, int mines, System.Tuple<int, int>[] minesPositions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SpotClicked", ReplyAction="http://tempuri.org/IMineSweeperService/SpotClickedResponse")]
        void SpotClicked(int row, int col, int tag, string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SpotClicked", ReplyAction="http://tempuri.org/IMineSweeperService/SpotClickedResponse")]
        System.Threading.Tasks.Task SpotClickedAsync(int row, int col, int tag, string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SpotFlaged", ReplyAction="http://tempuri.org/IMineSweeperService/SpotFlagedResponse")]
        void SpotFlaged(int row, int col, int tag, string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/SpotFlaged", ReplyAction="http://tempuri.org/IMineSweeperService/SpotFlagedResponse")]
        System.Threading.Tasks.Task SpotFlagedAsync(int row, int col, int tag, string fromPlayer, string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerWon", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerWonResponse")]
        void PlayerWon(string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerWon", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerWonResponse")]
        System.Threading.Tasks.Task PlayerWonAsync(string toPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GameStarted", ReplyAction="http://tempuri.org/IMineSweeperService/GameStartedResponse")]
        void GameStarted(MineSweeperClient.ServiceReference1.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GameStarted", ReplyAction="http://tempuri.org/IMineSweeperService/GameStartedResponse")]
        System.Threading.Tasks.Task GameStartedAsync(MineSweeperClient.ServiceReference1.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GameEnded", ReplyAction="http://tempuri.org/IMineSweeperService/GameEndedResponse")]
        void GameEnded(MineSweeperClient.ServiceReference1.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GameEnded", ReplyAction="http://tempuri.org/IMineSweeperService/GameEndedResponse")]
        System.Threading.Tasks.Task GameEndedAsync(MineSweeperClient.ServiceReference1.Game game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetOnGoingGames", ReplyAction="http://tempuri.org/IMineSweeperService/GetOnGoingGamesResponse")]
        string[] GetOnGoingGames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/GetOnGoingGames", ReplyAction="http://tempuri.org/IMineSweeperService/GetOnGoingGamesResponse")]
        System.Threading.Tasks.Task<string[]> GetOnGoingGamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerQuitInGame", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerQuitInGameResponse")]
        void PlayerQuitInGame(string Username, string Rival);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMineSweeperService/PlayerQuitInGame", ReplyAction="http://tempuri.org/IMineSweeperService/PlayerQuitInGameResponse")]
        System.Threading.Tasks.Task PlayerQuitInGameAsync(string Username, string Rival);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMineSweeperServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/UpdatePlayerList")]
        void UpdatePlayerList(string[] players);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/StartGamePutRequest")]
        void StartGamePutRequest(string fromPlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/PutMessage")]
        void PutMessage(string message, string fromPlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/RequestDenied")]
        void RequestDenied(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/StartGame")]
        void StartGame(string fromPlayer, int size, int mines, System.Tuple<int, int>[] minesPositions, bool flag);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/ClickSpot")]
        void ClickSpot(int row, int col, int tag, string fromPlayer, string other);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/SetFlag")]
        void SetFlag(int row, int col, int tag, string fromPlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/UpdateWinner")]
        void UpdateWinner();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMineSweeperService/UserExit")]
        void UserExit(string activator, string other);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMineSweeperServiceChannel : MineSweeperClient.ServiceReference1.IMineSweeperService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MineSweeperServiceClient : System.ServiceModel.DuplexClientBase<MineSweeperClient.ServiceReference1.IMineSweeperService>, MineSweeperClient.ServiceReference1.IMineSweeperService {
        
        public MineSweeperServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MineSweeperServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MineSweeperServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MineSweeperServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MineSweeperServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ClientConnected(string username) {
            base.Channel.ClientConnected(username);
        }
        
        public System.Threading.Tasks.Task ClientConnectedAsync(string username) {
            return base.Channel.ClientConnectedAsync(username);
        }
        
        public void ClientDisconnected(string username) {
            base.Channel.ClientDisconnected(username);
        }
        
        public System.Threading.Tasks.Task ClientDisconnectedAsync(string username) {
            return base.Channel.ClientDisconnectedAsync(username);
        }
        
        public bool PlayerExists(string player) {
            return base.Channel.PlayerExists(player);
        }
        
        public System.Threading.Tasks.Task<bool> PlayerExistsAsync(string player) {
            return base.Channel.PlayerExistsAsync(player);
        }
        
        public bool IsLegalUser(string username, string password) {
            return base.Channel.IsLegalUser(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> IsLegalUserAsync(string username, string password) {
            return base.Channel.IsLegalUserAsync(username, password);
        }
        
        public void EnterPlayerToDB(MineSweeperClient.ServiceReference1.Player player) {
            base.Channel.EnterPlayerToDB(player);
        }
        
        public System.Threading.Tasks.Task EnterPlayerToDBAsync(MineSweeperClient.ServiceReference1.Player player) {
            return base.Channel.EnterPlayerToDBAsync(player);
        }
        
        public void SendRequest(string fromPlayer, string toPlayer) {
            base.Channel.SendRequest(fromPlayer, toPlayer);
        }
        
        public System.Threading.Tasks.Task SendRequestAsync(string fromPlayer, string toPlayer) {
            return base.Channel.SendRequestAsync(fromPlayer, toPlayer);
        }
        
        public string[][] GetAllPlayers() {
            return base.Channel.GetAllPlayers();
        }
        
        public System.Threading.Tasks.Task<string[][]> GetAllPlayersAsync() {
            return base.Channel.GetAllPlayersAsync();
        }
        
        public string[][] GetAllGames() {
            return base.Channel.GetAllGames();
        }
        
        public System.Threading.Tasks.Task<string[][]> GetAllGamesAsync() {
            return base.Channel.GetAllGamesAsync();
        }
        
        public void DenyGameRequest(string fromPlayer, string toPlayer) {
            base.Channel.DenyGameRequest(fromPlayer, toPlayer);
        }
        
        public System.Threading.Tasks.Task DenyGameRequestAsync(string fromPlayer, string toPlayer) {
            return base.Channel.DenyGameRequestAsync(fromPlayer, toPlayer);
        }
        
        public void StartGameServer(string fromPlayer, string toPlayer, int size, int mines, System.Tuple<int, int>[] minesPositions) {
            base.Channel.StartGameServer(fromPlayer, toPlayer, size, mines, minesPositions);
        }
        
        public System.Threading.Tasks.Task StartGameServerAsync(string fromPlayer, string toPlayer, int size, int mines, System.Tuple<int, int>[] minesPositions) {
            return base.Channel.StartGameServerAsync(fromPlayer, toPlayer, size, mines, minesPositions);
        }
        
        public void SpotClicked(int row, int col, int tag, string fromPlayer, string toPlayer) {
            base.Channel.SpotClicked(row, col, tag, fromPlayer, toPlayer);
        }
        
        public System.Threading.Tasks.Task SpotClickedAsync(int row, int col, int tag, string fromPlayer, string toPlayer) {
            return base.Channel.SpotClickedAsync(row, col, tag, fromPlayer, toPlayer);
        }
        
        public void SpotFlaged(int row, int col, int tag, string fromPlayer, string toPlayer) {
            base.Channel.SpotFlaged(row, col, tag, fromPlayer, toPlayer);
        }
        
        public System.Threading.Tasks.Task SpotFlagedAsync(int row, int col, int tag, string fromPlayer, string toPlayer) {
            return base.Channel.SpotFlagedAsync(row, col, tag, fromPlayer, toPlayer);
        }
        
        public void PlayerWon(string toPlayer) {
            base.Channel.PlayerWon(toPlayer);
        }
        
        public System.Threading.Tasks.Task PlayerWonAsync(string toPlayer) {
            return base.Channel.PlayerWonAsync(toPlayer);
        }
        
        public void GameStarted(MineSweeperClient.ServiceReference1.Game game) {
            base.Channel.GameStarted(game);
        }
        
        public System.Threading.Tasks.Task GameStartedAsync(MineSweeperClient.ServiceReference1.Game game) {
            return base.Channel.GameStartedAsync(game);
        }
        
        public void GameEnded(MineSweeperClient.ServiceReference1.Game game) {
            base.Channel.GameEnded(game);
        }
        
        public System.Threading.Tasks.Task GameEndedAsync(MineSweeperClient.ServiceReference1.Game game) {
            return base.Channel.GameEndedAsync(game);
        }
        
        public string[] GetOnGoingGames() {
            return base.Channel.GetOnGoingGames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetOnGoingGamesAsync() {
            return base.Channel.GetOnGoingGamesAsync();
        }
        
        public void PlayerQuitInGame(string Username, string Rival) {
            base.Channel.PlayerQuitInGame(Username, Rival);
        }
        
        public System.Threading.Tasks.Task PlayerQuitInGameAsync(string Username, string Rival) {
            return base.Channel.PlayerQuitInGameAsync(Username, Rival);
        }
    }
}
