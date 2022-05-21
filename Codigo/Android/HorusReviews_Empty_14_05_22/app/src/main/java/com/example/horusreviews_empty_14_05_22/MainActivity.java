package com.example.horusreviews_empty_14_05_22;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    RecyclerView recyclerView;
    String s1[], s2[];
    int images[] = {R.drawable.eternals_mv,
            R.drawable.doctor_multiverse,
            R.drawable.batman,
            R.drawable.lightyear_mv,
            R.drawable.jujutsu_0,
            R.drawable.flash_mv};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        recyclerView = findViewById(R.id.recyclerView);

        s1 = getResources().getStringArray((R.array.filmes));
        s2 = getResources().getStringArray((R.array.descricao));

        MyAdapter myAdapter = new MyAdapter(this, s1, s2, images);
        recyclerView.setAdapter((myAdapter));
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

    }
}