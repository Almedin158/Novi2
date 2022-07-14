import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:eprodajamobile/model/kupci.dart';
import 'package:eprodajamobile/providers/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class KupciProvider extends BaseProvider<Kupci> {
  KupciProvider() : super("Kupci");

  @override
  Kupci fromJson(data) {
    return Kupci.fromJson(data);
  }
}