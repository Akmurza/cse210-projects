public class Customer{

    private string _clientsName;
    private Address _ClientsAddress;

    public Customer(string clientsName, Address ClientsAddress){
        this._clientsName=clientsName;
        this._ClientsAddress=ClientsAddress;
    }

    public string GetName(){
        return _clientsName;

    }

    public Address GetAddress(){
        return _ClientsAddress;

    }

    public bool IsInUSA(){
        return _ClientsAddress.IsInUSA();

    }


}