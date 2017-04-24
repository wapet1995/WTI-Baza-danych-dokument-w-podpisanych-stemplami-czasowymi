package com.example.dawid.wtistemple;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.view.View;
import android.widget.EditText;

import java.util.Objects;

public class rejestracjaActivity extends AppCompatActivity{

    EditText login, email, haslo, phaslo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rejestracja);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        login = (EditText) findViewById(R.id.loginET);
        email = (EditText) findViewById(R.id.emailET);
        haslo = (EditText) findViewById(R.id.hasloET);
        phaslo = (EditText) findViewById(R.id.phasloET);
    }

    public void click(View view) {

        new SprawdzenieWTle(this).execute();
       /* String h = haslo.getText().toString();
        String ph = phaslo.getText().toString();
        String em = email.getText().toString();


        if(Objects.equals(h, ph) ) { // sprawdzenie czy hasla sa identyczne oraz email

            Intent intent = new Intent(rejestracjaActivity.this, menuActivity.class);
            startActivity(intent);
        }*/

    }




}