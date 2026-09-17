package com.example.galeriakici;

import android.graphics.Color;
import android.os.Bundle;
import android.text.InputType;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Switch;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    private ImageView imageView;
    private Button prev;
    private Button next;
    private EditText editText;
    private Switch switch1;

    private int aktualneZdjecie = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        imageView = findViewById(R.id.imageView);
        prev = findViewById(R.id.prev);
        next = findViewById(R.id.next);
        editText = findViewById(R.id.editTextText);
        switch1 = findViewById(R.id.switch1);

        editText.setInputType(InputType.TYPE_CLASS_NUMBER);

        pokazZdjecie(1);

        prev.setOnClickListener(v -> {
            aktualneZdjecie--;

            if (aktualneZdjecie < 1) {
                aktualneZdjecie = 4;
            }

            pokazZdjecie(aktualneZdjecie);
        });

        next.setOnClickListener(v -> {
            aktualneZdjecie++;

            if (aktualneZdjecie > 4) {
                aktualneZdjecie = 1;
            }

            pokazZdjecie(aktualneZdjecie);
        });

        editText.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                if (s.length() == 1) {
                    int numer = Integer.parseInt(s.toString());

                    if (numer >= 1 && numer <= 4) {
                        aktualneZdjecie = numer;
                        pokazZdjecie(aktualneZdjecie);
                    }
                }
            }

            @Override
            public void afterTextChanged(Editable s) {
            }
        });

        switch1.setOnCheckedChangeListener((buttonView, isChecked) -> {
            if (isChecked) {
                findViewById(R.id.main).setBackgroundColor(Color.rgb(21, 101, 192));
            } else {
                findViewById(R.id.main).setBackgroundColor(Color.rgb(0, 121, 107));
            }
        });
    }

    private void pokazZdjecie(int numer) {
        switch (numer) {
            case 1:
                imageView.setImageResource(R.drawable.kot1);
                break;
            case 2:
                imageView.setImageResource(R.drawable.kot2);
                break;
            case 3:
                imageView.setImageResource(R.drawable.kot3);
                break;
            case 4:
                imageView.setImageResource(R.drawable.kot4);
                break;
        }
    }
}
