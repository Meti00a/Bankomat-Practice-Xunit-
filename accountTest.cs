using ATM;
namespace AtmTest;

public class AccountTest
{
  private Account account = new Account(5000);

  [Fact]
  public void DepositTest()
  {
    account.Deposit(5000);
    Assert.Equal(10000, account.GetBalance());
  }

  [Fact]
  public void WithdrawTest()
  {
    account.Withdraw(5000);
    Assert.Equal(0, account.GetBalance());
  }
}