using System;
using System.Collections.Generic;

namespace CM3D2.MaidVoicePitch.Managed {
    namespace Callbacks {
        namespace TBody {
            public static class LateUpdate {
                public delegate void Callback(global::TBody that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::TBody that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }

            public static class MoveHeadAndEye {
                public delegate void Callback(global::TBody that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::TBody that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace BoneMorph_ {
            public static class Blend {
                public delegate void Callback(global::BoneMorph_ that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::BoneMorph_ that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace AudioSourceMgr {
            public static class Play {
                public delegate void Callback(global::AudioSourceMgr that, float f_fFadeTime, bool loop);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::AudioSourceMgr that, float f_fFadeTime, bool loop) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that, f_fFadeTime, loop);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }

            public static class PlayOneShot {
                public delegate void Callback(global::AudioSourceMgr that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::AudioSourceMgr that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace CharacterMgr {
            public static class PresetSet {
                public delegate void Callback(global::CharacterMgr that, Maid f_maid, global::CharacterMgr.Preset f_prest);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::CharacterMgr that, Maid f_maid, global::CharacterMgr.Preset f_prest) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that, f_maid, f_prest);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace DynamicSkirtBone {
            public static class PreUpdateSelf {
                public delegate void Callback(global::DynamicSkirtBone that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::DynamicSkirtBone that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }

            public static class PostUpdateSelf {
                public delegate void Callback(global::DynamicSkirtBone that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::DynamicSkirtBone that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace jiggleBone {
            public static class PreLateUpdateSelf {
                public delegate void Callback(global::jiggleBone that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::jiggleBone that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }

        namespace jiggleBone {
            public static class PostLateUpdateSelf {
                public delegate void Callback(global::jiggleBone that);
                public static Callbacks<Callback> Callbacks = new Callbacks<Callback>();

                public static void Invoke(global::jiggleBone that) {
                    try {
                        foreach (Callback callback in Callbacks.Values) {
                            callback(that);
                        }
                    } catch (Exception e) {
                        Helper.ShowException(e);
                    }
                }
            }
        }


        public class Callbacks<T> : SortedDictionary<string, T> { }
    }
}
