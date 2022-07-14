
import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';

part 'kupci.g.dart';

@JsonSerializable()
class Kupci {
  int? kupacId;
  String? ime;
  String? prezime;
  String? email;


  Kupci(){}

  factory Kupci.fromJson(Map<String, dynamic> json) => _$KupciFromJson(json);

  /// Connect the generated [_$KupciToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KupciToJson(this);
}