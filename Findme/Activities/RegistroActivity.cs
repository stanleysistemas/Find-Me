using System;
using System.Net;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Widget;
using RestSharp;
using RestSharp.Deserializers;


namespace Findme.Activities
{
    [Activity(Label = "Registro", ScreenOrientation = ScreenOrientation.Portrait)]
    public class RegistroActivity : BaseActivity
    {
        EditText txtusername;
        EditText txtpassword;
        EditText txtconfirmpassword;
        EditText txtemail;
        EditText txtfirstname;
        EditText txtlastname;

        Button button_registrar;

        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.logar;

            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Intent newIntent;
             SetContentView(Resource.Layout.registrar);

            // Create your application here
            button_registrar = FindViewById<Button>(Resource.Id.button_registrar);

           
            
            TextInputLayout textuserNameInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtusernameInputLayout);
            EditText txtusername = FindViewById<EditText>(Resource.Id.txtusername);

            TextInputLayout textpasswordInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtsenhaInputLayout);
            EditText txtpassword = FindViewById<EditText>(Resource.Id.txtsenha);


            TextInputLayout textconfirmpasswordInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtconfirmasenhaInputLayout);
            EditText txtconfirmpassword = FindViewById<EditText>(Resource.Id.txtconfirmasenha);

            TextInputLayout textemailInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtemailInputLayout);
            EditText txtemail = FindViewById<EditText>(Resource.Id.txtemail);

            TextInputLayout textfirstNameInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtfirstNameInputLayout);
            EditText txtfirstname = FindViewById<EditText>(Resource.Id.txtfirstName);

            TextInputLayout textlastNameInputLayout = FindViewById<TextInputLayout>(Resource.Id.txtlastNameInputLayout);
            EditText txtlastname = FindViewById<EditText>(Resource.Id.txtlastName);


            FindViewById<Button>(Resource.Id.button_registrar).Click += (sender, e) =>
            {
                //Toast.MakeText(this, txtusername.Text, ToastLength.Short).Show();
                //Toast.MakeText(this, txtpassword.Text, ToastLength.Short).Show();
                //Toast.MakeText(this, txtconfirmpassword.Text, ToastLength.Short).Show();
                //Toast.MakeText(this, txtemail.Text, ToastLength.Short).Show();
                //Toast.MakeText(this, txtfirstname.Text, ToastLength.Short).Show();
                //Toast.MakeText(this, txtlastname.Text, ToastLength.Short).Show();


                if (txtusername.Text == "")
                {
                    Toast.MakeText(this, "Campo Nome do Usuário obrigatório...", ToastLength.Short).Show();

                }
                else if (txtpassword.Text == "")
                {
                    Toast.MakeText(this, "Campo Senha do Usuário obrigatório...", ToastLength.Short).Show();
                }
                else if (txtconfirmpassword.Text == "")
                {
                    Toast.MakeText(this, "Campo Confirmação de Senha do Usuário obrigatório...", ToastLength.Short).Show();
                }
                else if ((txtpassword.Text) != (txtconfirmpassword.Text))
                {
                    Toast.MakeText(this, "Campo Senha e Confirmação de Senha não Coincidem...", ToastLength.Short).Show();
                   // txtpassword.FindFocus();
                }
                else
                {
                    //string login;
                    //var client =
                    //    new RestClient("https://aspnetidentitywebapi20161025090604.azurewebsites.net/");

                    //var request = new RestRequest(Method.POST);

                    //request.Resource = "api/account/create";

                    //request.RequestFormat = DataFormat.Json;

                    
                    //request.AddParameter("Email", txtemail.Text);
                    //request.AddParameter("Username", txtusername.Text);
                    //request.AddParameter("FirstName", txtfirstname.Text);
                    //request.AddParameter("LastName", txtlastname.Text);
                    //request.AddParameter("Password", txtpassword.Text);
                    //request.AddParameter("ConfirmPassword", txtconfirmpassword.Text);

                    //var response = client.Execute(request);

                    //if (response.StatusCode == HttpStatusCode.OK)
                    //{
                    //    String content = response.Content;

                    //    try
                    //    {
                    //        Toast.MakeText(this, content.ToString(),

                    //            ToastLength.Short).Show();
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                    //    }

                    //}
                    //else
                    //{
                    //    String content = response.StatusDescription;
                    //    try
                    //    {
                    //        Toast.MakeText(this, content.ToString(),

                    //            ToastLength.Short).Show();
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                    //    }
                    //}

                    


                    



                    // login = response.ToString();




                    //if (login != "")
                    //{
                    //    try
                    //    {
                    //        Toast.MakeText(this,
                    //            "Registro feito com sucesso...Aguarde Email para Confirmação de Cadastro.",
                    //            ToastLength.Short).Show();
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                    //    }
                    //}
                    //else
                    //{
                    //    try
                    //    {
                    //        Toast.MakeText(this,
                    //            "Erro ao tentar cadastrar usuario. "+ login.ToString(),
                    //            ToastLength.Short).Show();
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
                    //    }
                    //}



                    // newIntent = new Intent(this, typeof(MainActivity));
                    // newIntent.AddFlags(ActivityFlags.ClearTop);
                    // newIntent.AddFlags(ActivityFlags.SingleTop);
                    //StartActivity(newIntent);
                    //Finish();

                }

            };
        }

        public override void OnBackPressed()
        {
              var newIntent = new Intent(this, typeof(LoginActivity));
             newIntent.AddFlags(ActivityFlags.ClearTop);
            // newIntent.AddFlags(ActivityFlags.SingleTop);
             StartActivity(newIntent);
             Finish();

        }


    }
}
